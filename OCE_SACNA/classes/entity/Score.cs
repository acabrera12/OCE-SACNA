using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class Score : Entity
{
    public Student Student { get; set; }
    public Subject Subject { get; set; }

    public float Lapse_1 { get; set; }
    public float Lapse_1_def { get; set; }
    public int Lapse_1_inas { get; set; }

    public float Lapse_2 { get; set; }
    public float Lapse_2_def { get; set; }
    public int Lapse_2_inas { get; set; }

    public float Lapse_3 { get; set; }
    public float Lapse_3_def { get; set; }
    public int Lapse_3_inas { get; set; }

    public float Final { get; set; }
    public float Final_def { get; set; }
    public int Final_inas { get; set; }

    public Score(Student student, Subject subject, float Lapse_1 = 0f, float Lapse_2 = 0f, float Lapse_3 = 0f, float final = 0f, float Lapse_1_def = 0f, float Lapse_2_def = 0f, float Lapse_3_def = 0f, float final_def = 0f, int Lapse_1_inas = 0, int Lapse_2_inas = 0, int Lapse_3_inas = 0, int final_inas = 0)
    {
        this.Student = student;
        this.Subject = subject;

        this.Lapse_1 = Lapse_1;
        this.Lapse_2 = Lapse_2;
        this.Lapse_3 = Lapse_3;
        this.Final = final;

        this.Lapse_1_def = Lapse_1_def;
        this.Lapse_2_def = Lapse_2_def;
        this.Lapse_3_def = Lapse_3_def;
        this.Final_def = final_def;

        this.Lapse_1_inas = Lapse_1_inas;
        this.Lapse_2_inas = Lapse_2_inas;
        this.Lapse_3_inas = Lapse_3_inas;
        this.Final_inas = final_inas;
    }
}
