using OCESACNA.Engine.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OCESACNA.Engine.DBCollections;

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


        private static async Task GetNonce()
        {
            Request request = new Request("GetNonce", new Dictionary<string, string>());

            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add("Content_type", "aplication/json");

            try
            {
                var data = JsonSerializer.Serialize(request);

                HttpContent content = new StringContent(data);

                HttpResponseMessage response = await Client.PostAsync(GetUsingURL(), content);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"HttpResponse status isn't success: {response.StatusCode}");
                    return;
                }

                string responseBody = await response.Content.ReadAsStringAsync();

                RequestCompleted(request, responseBody);
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
                var data = JsonSerializer.Serialize<Request>(request);

                HttpContent content = new StringContent(data, Encoding.UTF8);

                HttpResponseMessage response = await Client.PostAsync(GetUsingURL() + data, content);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"HttpResponse status isn't success: {response.StatusCode}");
                    return;
                }

                string responseBody = await response.Content.ReadAsStringAsync();

                RequestCompleted(request, responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"{e}");
            }
        }

        private static void RequestCompleted(Request request, string ResponseBody)
        {
            Console.WriteLine(ResponseBody);
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
    }
}
