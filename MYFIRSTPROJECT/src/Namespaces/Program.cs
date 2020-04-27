using System;
namespace namespaces
{
    class Program1
    {
        public void method1(){
            Console.WriteLine("I am from namespace1");
        }
    }
}

namespace namespace1{
    class Program2
    {
        public void method1(){
            Console.WriteLine("I am from namespace2");
        }
    
    }
    }
public class Executor{  
public static void Main(String [] args){
namespaces.Program1 obj = new namespaces.Program1();
namespace1.Program2 obj1 = new namespace1.Program2();
obj.method1();
obj1.method1();
}
} 

/*
* Below is the code to use the namespace with using keyword
*/

/*using System;  
using First;  
using Second;  
namespace First {  
public class Hello  
{  
    public void sayHello() { Console.WriteLine("Hello Namespace"); }  
}  
}  
namespace Second  
{  
    public class Welcome  
    {  
        public void sayWelcome() { Console.WriteLine("Welcome Namespace"); }  
    }  
}  
public class TestNamespace  
{  
    public static void Main()  
    {  
        Hello h1 = new Hello();  
        Welcome w1 = new Welcome();  
        h1.sayHello();  
        w1.sayWelcome();  
    }  
} */
