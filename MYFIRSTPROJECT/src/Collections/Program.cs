using System;
using System.Collections.Generic;

namespace Collections
{
    public class CollectionsExamples{
    public void listOperation(){
     var names = new List<string>();  
        names.Add("Sonoo Jaiswal");  
        names.Add("Ankit");  
        names.Add("Peter");  
        names.Add("Irfan"); 
         var names2 = new List<string>() {"aaaa", "bbbb", "cccc", "dddd" };   
          foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
         foreach (var name in names2)  
        {  
            Console.WriteLine(name);  
        }  
    }

    public void dictionaryOperations(){
        Dictionary<string, string> names = new Dictionary<string, string>();  
        names.Add("1","Sonoo");  
        names.Add("2","Peter");  
        names.Add("3","James");  
        names.Add("4","Ratan");  
        names.Add("5","Irfan");  
  
        foreach (KeyValuePair<string, string> kv in names)  
        {  
            Console.WriteLine(kv.Key+" "+kv.Value);  
        }  
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CollectionsExamples obj = new CollectionsExamples();
            obj.listOperation();
            obj.dictionaryOperations();
        }
    }
}
