using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class Score : Entity
{
    public Student student { get; set; }
    public Subject subject { get; set; }

    public float lapse_1 { get; set; }
    public float lapse_1_def { get; set; }
    public int lapse_1_inas { get; set; }

    public float lapse_2 { get; set; }
    public float lapse_2_def { get; set; }
    public int lapse_2_inas { get; set; }

    public float lapse_3 { get; set; }
    public float lapse_3_def { get; set; }
    public int lapse_3_inas { get; set; }

    public float final { get; set; }
    public float final_def { get; set; }
    public int final_inas { get; set; }

    public Score()
    {
        this.student = new Student();
        this.subject = new Subject();

        this.lapse_1 = 0f;
        this.lapse_2 = 0f;
        this.lapse_3 = 0f;
        this.final = 0f;

        this.lapse_1_def = 0f;
        this.lapse_2_def = 0f;
        this.lapse_3_def = 0f;
        this.final_def = 0f;

        this.lapse_1_inas = 0;
        this.lapse_2_inas = 0;
        this.lapse_3_inas = 0;
        this.final_inas = 0;
    }

    public Score(Student student, Subject subject, float lapse_1 = 0f, float lapse_2 = 0f, float lapse_3 = 0f, float final = 0f, float lapse_1_def = 0f, float lapse_2_def = 0f, float lapse_3_def = 0f, float final_def = 0f, int lapse_1_inas = 0, int lapse_2_inas = 0, int lapse_3_inas = 0, int final_inas = 0)
    {
        this.student = student;
        this.subject = subject;

        this.lapse_1 = lapse_1;
        this.lapse_2 = lapse_2;
        this.lapse_3 = lapse_3;
        this.final = final;

        this.lapse_1_def = lapse_1_def;
        this.lapse_2_def = lapse_2_def;
        this.lapse_3_def = lapse_3_def;
        this.final_def = final_def;

        this.lapse_1_inas = lapse_1_inas;
        this.lapse_2_inas = lapse_2_inas;
        this.lapse_3_inas = lapse_3_inas;
        this.final_inas = final_inas;
    }
}
