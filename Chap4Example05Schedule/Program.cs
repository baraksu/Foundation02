
using System;

public class Lesson
{
    private string subject;
    private string teacher;
    private int roomNo;

    public Lesson(string subject, string teacher, int roomNum)
    {
        this.subject = subject;
        this.teacher = teacher;
        this.roomNo = roomNum;
    }
    public int GetRoomNo() { return roomNo; }
    public string GetSubject() { return subject; }
    public string GetTeacher() { return teacher; }
}

public class Chap4Example05Schedule
{
    public static void SameRoom(Lesson[,] L)
    {
        bool same;
        int room;
        for (int j = 0; j < L.GetLength(1); j++)
        {
            room = L[0, j].GetRoomNo(); //חדר של שיעור ראשון באותו יום 
            same = true;
            for (int i = 1; i < L.GetLength(0) && same == true; i++)
            {
                if (L[i, j] != null)
                    if (L[i, j].GetRoomNo() != room)
                        same = false;
            }

            if (same == true)
                Console.WriteLine("Same room:" + room + " on day " + (j + 1));
        }
    }

    public static int HoursForSubj(Lesson[,] L, string subj)
    {
        int count = 0;
        for (int i = 0; i < L.GetLength(0); i++)
        {
            for (int j = 1; j < L.GetLength(1); j++)
                if (L[i, j] != null)
                    if (L[i, j].GetSubject().Equals(subj))
                        count++;
        }

        return count;
    }

    public static void Main(string[] args)
    {
        Lesson[,] m = new Lesson[2, 2]; // יצירת מערך של עצמים
        string maxSubj = "";
        int hours = -1;
        int maxHours = -1;
        for (int j = 0; j < m.GetLength(1); j++)
            for (int i = 0; i < m.GetLength(0); i++)
            {
                Console.WriteLine("Insert subject,teacher & room no. for lesson " +
                                  (i + 1) + " in day " + (j + 1));
                m[i, j] = new Lesson(Console.ReadLine(), Console.ReadLine(),
                    int.Parse(Console
                        .ReadLine())); // יצירת עצמים במערך                                                                                                          
            }

        SameRoom(m); //  זימון פעולה מסעיף ב
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                if (m[i, j] != null) //אם יש שיעור ביום ובשעה 
                {
                    hours = HoursForSubj(m, m[i, j].GetSubject());
                    // מספר השעות השבועיות שהמקצוע נלמד  (ע"י הפעולה מסעיף ג) 
                    if (hours > maxHours) // אם מספר השעות גדול מהמקסימלי
                    {
                        maxHours = hours; // עדכון מספר השעות המקסימלי
                        maxSubj = m[i, j].GetSubject(); // עדכון המקצוע
                    }
                }
        }

        Console.WriteLine("The most teaching professional is " + maxSubj + "for " +
                          maxHours + " hours");
        Console.ReadLine();
    }
}



