var act1 = new Actor("Andrey",55,"Man" )
System.Console.WriteLine(act1.AddMovie());
System.Console.WriteLine(act1. GetMoviesPlayed());
System.Console.WriteLine(act1.GetAge());
System.Console.WriteLine(act1.GetGender());





public class Actor
{
    string _fullname;
    int _age;
    string _gender;
    string _moviesPlayed ;
   public  void AddMovie(string movieTitle)
   {
     _moviesPlayed=movieTitle;
   }
   public string GetMoviesPlayed()
   {
    return _moviesPlayed;
   }  
   public void SetAge(int age)
   {
       _age=age;
   }
   public int GetAge()
   {
    return _age;

   }
   public void SetGender(string gender)
   {
    _gender=gender;

   }
   public string GetGender()
   {
    return _gender;
   }
   public  Actor (string fullName, int age, string gender)
   {
       _fullname=fullName;
       _age=age;
       _gender=gender;
   }


}