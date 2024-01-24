var st1 = new Student("Orzu", 21, 11);
System.Console.WriteLine(st1.Study());
System.Console.WriteLine(st1.GetGrade());





public class Student
{
   string _fullname;
   int _age ;
   double _grade ;

   public string Study(){
  return $"{_fullname} is studying.";
          
    }  
    public void  SetGrade (int newGrade) {
         _grade=newGrade;
    }
    public double GetGrade()
    {
        return _grade;
    }

    public Student ()
    {
        
    }
    public Student(string fullname, int age)
    {
      _fullname=fullname;
      _age=age;   
    }
        public Student(string fullname, int age, double grade)
    {
      _fullname=fullname;
      _age=age;  
      _grade=grade; 
    }
    }
 
   









