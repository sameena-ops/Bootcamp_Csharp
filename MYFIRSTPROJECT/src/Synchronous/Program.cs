using System;
using Asynchronous;

namespace Asynchronous
{

    public class Coffee{
        public void pourCoffee(){
            Console.WriteLine("coffee is ready");
        }
    }

    public class Egg{
       public void fryEggs(){
       Console.WriteLine("eggs are ready");
       }
    }

    public class Bacon{
        public void fryBacon(){
         Console.WriteLine("bacon is ready");
        }
    }
    public class Toast{
        public String toastBread(){
            String str ="sending toast to apply butter and jam";
            return str;
        }
        public void applyButter(String toast){
             Console.WriteLine("Butter applied");
        }
        public void applyJam(String toast){
           Console.WriteLine("jam applied");
           
        }
    }

    }
    public class Juice{
        public void pourJuice(){
            Console.WriteLine("orange juice is ready");
        }
    class Program
    {
    static void Main(string[] args)
        {
     
     Coffee cup = new Coffee();
    cup.pourCoffee();
    
    Egg eggs = new Egg();
    eggs.fryEggs();
   
    Bacon bacon = new Bacon();
    bacon.fryBacon();
   
    Toast toast = new Toast();
    String prepareToast=toast. toastBread();
    toast.applyButter(prepareToast);
    toast.applyJam(prepareToast);
    Console.WriteLine("toast is ready");
    Juice oj = new Juice();
    oj.pourJuice();
    Console.WriteLine("Breakfast is ready!");
     }
     
    }
}
