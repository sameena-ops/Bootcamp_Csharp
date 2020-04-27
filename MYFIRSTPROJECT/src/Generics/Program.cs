using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyGenericClss<int> mgc = new MyGenericClss<int>(10);
            mgc.genericMethod(100);
            GenericClass gc = new GenericClass();
            gc.Show("sameena");
            gc.Show(472);
            gc.Show('S');
        }
    }



    class MyGenericClss<T>
    {
        private T genericMemberVariable;
        public MyGenericClss(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {

            Console.WriteLine("parameter type:{0}, value:{1}", typeof(T).ToString(), genericMemberVariable);
            Console.WriteLine("parameter type:{0}, value:{1}", typeof(T).ToString(), genericParameter);
            return genericParameter;
        }
    }
    class GenericClass
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }

}

