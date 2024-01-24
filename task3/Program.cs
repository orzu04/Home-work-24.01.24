var dok1 = new Doctor("Miorzo","Genekolog",20 );
System.Console.WriteLine(dok1.TreatPatient("Zulya"));
System.Console.WriteLine(dok1. PrescribeMedication("Zulyz", "Mirzo"));
System.Console.WriteLine(dok1.PerformMedicalExamination("Gulya"));
System.Console.WriteLine(dok1.GetExperience());


public class Doctor
{
     string _fullname;
     string _specialty;
     int _experience;
    public string  TreatPatient(string patientName)   {
    return $"{_fullname} {_specialty}, лечит пациента по имени {patientName} ";
   } 
    public string  PerformMedicalExamination(string patientName)
   {
    return $"{_fullname} проводит медицинское обследование для пациента по имени {patientName}";
   }
public string PrescribeMedication(string patientName, string medication)
{
 return $"{_fullname} назначает {medication} пациенту по имени {patientName}";

}
public void  SetExperience(int years)
{
    _experience=years;

}
public int  GetExperience()
{
    return _experience;

}
  public Doctor ()
    {
        
    }
     public Doctor (string fullName, string specialty)
    {
      _fullname=fullName;
      _specialty=specialty;

    }
         public Doctor (string fullName, string specialty, int experience)
    {
      _fullname=fullName;
      _specialty=specialty;
        _experience=experience;

    }
}