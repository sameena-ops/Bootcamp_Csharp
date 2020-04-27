using System;

namespace Encapsulation
{

    public class Student{
     public String id;
     public String name;
     public String email;
        
    }
    }
    namespace Encapsulation{
 class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Student student = new Student();
            student.id = "101";
            student.name="sameena";
            student.email ="abc@gmail.com";
            Console.WriteLine(student.id);
            Console.WriteLine(student.name);
            Console.WriteLine( student.email);

        }
    }
}
