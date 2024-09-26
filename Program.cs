using System;
using System.Globalization;
namespace MaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type width: ");
            int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type height: ");
            int height = Int32.Parse(Console.ReadLine());
            int[,] array = new int[width, height];
            int max =0;
            for (int row = 0; row < array.GetLength(0); row++)
            {

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = Int32.Parse(Console.ReadLine());
                    if(array[row,col]>max){
                        max = array[row,col];
                    }
                }
            }
            Console.WriteLine("Your Maxtrix: ");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.Write("\n");
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col]+" ");
                }

            }
            Console.WriteLine("\nMax value is: "+max);

        }
    }
}