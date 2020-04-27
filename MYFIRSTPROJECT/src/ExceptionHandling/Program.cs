using System;

namespace ExceptionHandline
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
           //obj.withoutTryCatch();
            //obj.withTryCatch();
           obj.checkedExample();
           obj.uncheckedExample();
        }

        public void withTryCatch(){
            int a=10;
            int b=0;
            try{
            int c = a/b;
            }catch(Exception e){

                Console.WriteLine("This is the code executed after exception occured");
            }

        }

        public void withoutTryCatch(){
            int a=10;
            int b=0;
            int c = a/b;
            Console.WriteLine("This is the code executed after exception occured");
        }

        public void checkedExample(){
        checked  
            {  
                int val = int.MaxValue;  
                Console.WriteLine(val + 2);  
            }  

        }

        public void uncheckedExample()
        {
            unchecked  
            {  
                int val = int.MaxValue;  
                Console.WriteLine(val + 2);  
            }  
        }
    }
}
