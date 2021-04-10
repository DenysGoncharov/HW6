using System;

namespace NestedMethodForArra
{


    static class Nested
    {
        static public void Sorter(this int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] > array[j]) 
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number elements of array:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
         
            Random rdm = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rdm.Next(0,  20);
            }

             void Show(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine( array[i]);
                }
            }
            Console.WriteLine("randomw array");
            Show(array);
            Console.WriteLine("sorted array");
            array.Sorter();
            Show(array);

            Console.ReadKey();
        }
    }
}
