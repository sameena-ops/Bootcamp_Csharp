using System;

namespace ConsoleApp2 {

    public class CheckArgs
    {
        public CheckArgs(int n1, int n2)
        {
            Console.WriteLine("I am the constructor with 2 params and the sum is " + (n1 + n2));
        }

        public CheckArgs(int n1, int n2, int n3)
        {
            Console.WriteLine("I am the constructor with 3 params and the sum is " + (n1 + n2 + n3));
        }

    }
  
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(args[0]);
            int n2 = int.Parse(args[1]);
            int n3= int.Parse(args[2]);

            CheckArgs obj = new CheckArgs(n1, n2);
                
            CheckArgs obj1 = new CheckArgs(n1, n2, n3);
            Console.ReadKey();
        }
    }
}


