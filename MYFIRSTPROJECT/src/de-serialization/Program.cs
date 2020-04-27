using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace de_serialization
{
    [Serializable]  
class Student  
{  
    public int rollno;  
    public string name;  
    public Student(int rollno, string name)  
    {  
        this.rollno = rollno;  
        this.name = name;  
    }  
}  
    public class Program
    {
        public static void Main(string[] args)
        {
           /* try{
             String c = args[0];
             }
             catch(IndexOutOfRangeException e){
                Console.WriteLine(e);
            } */
            Program obj = new Program();
           // obj.serialize(); 
            obj.deserialize(); 
            
        }
        void serialize(){
        FileStream stream = new FileStream("/Users/sameenasyed/Documents/Dotnet/MYFIRSTPROJECT/src/de-serialization/sss.txt", FileMode.OpenOrCreate);  
        BinaryFormatter formatter=new BinaryFormatter();  
        Student s = new Student(101, "sam");  
        formatter.Serialize(stream, s); 
        Console.WriteLine("Serialization is successful written as binary to the file specified");
        stream.Close();
            } 

        void deserialize(){
        FileStream stream = new FileStream("/Users/sameenasyed/Documents/Dotnet/MYFIRSTPROJECT/src/de-serialization/sss.txt", FileMode.OpenOrCreate);  
        BinaryFormatter formatter=new BinaryFormatter();  
        Student s=(Student)formatter.Deserialize(stream);  
        Console.WriteLine("Rollno: " + s.rollno);  
        Console.WriteLine("Name: " + s.name);  
        stream.Close();  
            } 

    }
    }
