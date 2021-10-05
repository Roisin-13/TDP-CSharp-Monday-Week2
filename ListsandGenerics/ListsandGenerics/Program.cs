using System;

namespace ListsandGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //==========Array============//
            int[] arr = { 1, 2, 3, 4 };
            //==========ArrayList created============//
            CustomArrayList arrList = new CustomArrayList(arr);
            //==========ArrayList TESTING============//
            Console.WriteLine("printing values");
            arrList.PrintValues();
            Console.WriteLine();
            arrList.Add(7);
            Console.WriteLine("printing values after adding");
            arrList.PrintValues();
            Console.WriteLine();
            Console.WriteLine("popped value and after");
            Console.WriteLine(arrList.Pop());
            arrList.PrintValues();
        }
    }
}
