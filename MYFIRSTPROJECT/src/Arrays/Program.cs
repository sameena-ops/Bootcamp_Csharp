using System;

namespace Arrays
{


    class Program
    {
        public void printArrayItems(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine("printing valuses from func " + i);
            }
        }

        public void multiDimensional()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  
            int[,] arr1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] arr3 = new int[3,3]= { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }


        /*
        params is a keyword which is used to specify a parameter that takes variable number of arguments
        */
        public void usingParams(params int[] val)
        {
            // Params Paramater  
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            int[] arr = new int[4];
            int[] arr1 = new int[4] { 1, 2, 3, 4 };
            int[] arr2 = { 11, 22, 33 };
            String[] str = new string[] { "sam" };
            arr[0] = 123;
            arr[3] = 456;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Hello World!" + arr[i]);
            }

            foreach (int iter in arr1)
            {
                Console.WriteLine("values are " + iter);
            }

            obj.printArrayItems(arr2);
            obj.multiDimensional();
            obj.usingParams(10, 12, 14, 16);
        }
    }
}
