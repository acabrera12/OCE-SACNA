using OCESACNA.Engine.Collections;
using OCESACNA.Engine.DBCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OCESACNA.Engine.Core
{
    public static partial class ConnectManager
    {
        private const string ServerURL = "http://localhost/OCESACNA-V2/DB/";
        private const string ServerKey = "d286019a0262574f0c185667e5bdc984ac5d18942d1f72b8fe68ee334ddfa449";

        private static bool UseAltServerURL = false;
        private static string AltServerURL = "http://127.0.0.1/OCESACNA-V2/DB/";

        private static string Nonce = string.Empty;
        private static HttpClient Client = new HttpClient();

        private static bool isRequesting = false;
        private static List<Request> RequestQueue = new List<Request>();

        private static async Task StartUpdate()
        {
            while (true)
            {
                await Update();
                await Task.Delay(40);
            }
        }

        private static async Task Update()
        {
            if (isRequesting || !RequestQueue.Any())
            {
                return;
            }

            if (Nonce == string.Empty)
            {
                await GetNonce();
                return;
            }

            isRequesting = true;
            await SendRequest(QueuePopFront());
        }

        private static async Task GetNonce()
        {
            Request request = new Request("GetNonce", new Dictionary<string, string>());

            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add("Content_type", "aplication/json");

            try
            {
                var data = JsonSerializer.Serialize(request.Data);
                string body = $"?command={request.Command}&data={data}";

                HttpContent content = new StringContent(body, Encoding.UTF8);

                HttpResponseMessage response = await Client.PostAsync(GetUsingURL() + body, content);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"HttpResponse status isn't success: {response.StatusCode}");
                }

                string responseBody = await response.Content.ReadAsStringAsync();

                RequestCompleted(request, responseBody, response.StatusCode);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"{e}");
            }
        }

        private static async Task SendRequest(Request request)
        {
            string cnonce = BitConverter.ToString(RandomBytes(32));
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] nonceBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(cnonce));
                cnonce = BitConverter.ToString(nonceBytes).Replace("-", "");
            }

            string clientHash = Nonce + cnonce + ServerKey;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(clientHash));
                clientHash = BitConverter.ToString(hashBytes).Replace("-", "");
            }

            Nonce = string.Empty;

            Client.DefaultRequestHeaders.Clear();

            Client.DefaultRequestHeaders.Add("cnonce", cnonce);
            Client.DefaultRequestHeaders.Add("hash", clientHash);
            Client.DefaultRequestHeaders.Add("Content_type", "aplication/json");

            try
            {
                var data = JsonSerializer.Serialize(request.Data);
                string body = $"?command={request.Command}&data={data}";

                HttpContent content = new StringContent(body, Encoding.UTF8);

                HttpResponseMessage response = await Client.PostAsync(GetUsingURL() + body, content);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"HttpResponse status isn't success: {response.StatusCode}");
                }

                string responseBody = await response.Content.ReadAsStringAsync();

                RequestCompleted(request, responseBody, response.StatusCode);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"{e}");
            }
        }

        private static void RequestCompleted(Request request, string ResponseBody, HttpStatusCode resultCode)
        {
            if (resultCode != HttpStatusCode.OK)
            {
                Console.WriteLine($"Error: httpStatusCode {resultCode}");
            }

            var json = JsonDocument.Parse(ResponseBody).RootElement;
            DBResponse response = new DBResponse(
                json.GetProperty("error").ToString(),
                json.GetProperty("command").ToString(),
                json.GetProperty("response")
                );

            if (response.error != "none")
            {
                Console.WriteLine($"Database returned a error: {response.error}");
                isRequesting = false;
                return;
            }

            if (response.command == "GetNonce")
            {
                Nonce = response.response.ToString();
                isRequesting = false;
                return;
            }

            RequestEventArgs args = new RequestEventArgs(response);
            request.RequestCompleted.Emit(args);

            isRequesting = false;
        }

        private static byte[] RandomBytes(int length)
        {
            byte[] bytes = new byte[length];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return bytes;
        }

        private static string GetUsingURL()
        {
            if (UseAltServerURL)
            {
                return AltServerURL;
            }
            return ServerURL;
        }

        private static Request QueuePopFront()
        {
            Request r = RequestQueue[0];
            RequestQueue.RemoveAt(0);
            return r;
        }

        private static void AddToQueue(Request r)
        {
            RequestQueue.Add(r);
        }

        internal static void Init()
        {
            Task.Run(() => StartUpdate());
        }
    }
}
