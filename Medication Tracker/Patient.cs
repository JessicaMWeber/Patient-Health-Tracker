using System;

public class Patient
{
    public Patient()
    {
    }
    public Patient(int id, decimal t, int bpt, int bpb, byte o, byte r, string n, DateTime bday, int rn, string a, string cs)
    {
        ID = id;

        Temp = t;
        BloodPressureTop = bpt;
        BloodPressureBottom = bpb;
        Oxygen = o;
        Respiration = r;

        Name = n;
        DOB = bday;
        RoomNumber = rn;
        Allergies = a;
        CodeStatus = cs;

    }

    public int ID { get; set;}
    public decimal Temp { get; set; }
    public int BloodPressureTop { get; set; }
    public int BloodPressureBottom { get; set; }
    public int Pulse { get; set; }
    public int Oxygen { get; set; }
    public int Respiration { get; set; }

    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public int RoomNumber { get; set; }
    public string Allergies { get; set; }
    public string CodeStatus { get; set; }

    
}
