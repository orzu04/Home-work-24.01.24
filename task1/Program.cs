


Teacher teacher1 = new Teacher ();
teacher1.Fullname = "Mirzoev Muhammad";
teacher1.Subjact = "Matem";
teacher1.experience = 23;
System.Console.WriteLine(teacher1.Teach());
System.Console.WriteLine(teacher1.GetExperience());


public class Teacher
{
  public string Fullname;
  public string Subjact;
  public int experience;
  
  public string Teach()
  {
    return $" {Fullname} teaching {Subjact}  ";
  }
   public void SetExperience(int years)
   {
      experience = years;
   } 
 
   public int GetExperience()
   {
    return experience;
   }
  

}


