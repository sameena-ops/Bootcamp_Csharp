using System;

public static class MyMath{
    public static String name = "world";
    public static int square(int n){
        return n*n;
    }
}
namespace ObjectsAndClasses
{
   public class Student
    {
         int id;
       String name;

       public void insertData(int i,String n){
           id=i;
           name = n;

       } 

       public void display(){
           Console.WriteLine("Roll Number "+ id+" Fullname "+name);
       }
       public static void Main(String [] args){
        Console.WriteLine("Hello"+MyMath.name);
        Console.WriteLine("square of a given number is "+ MyMath.square(2));
    }
    }

    public class Teacher{
        public static void Main123(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student s1= new Student();
            Student s2= new Student();
            s1.insertData(101,"sameena syed");
            s2.insertData(102,"syed");
            s1.display();
            s2.display();
        }

    }
    
}
