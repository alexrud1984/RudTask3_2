using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Sorry no comments this time
/// </summary>
namespace RudTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte MaxArraySize = 255;
            int[] UserArray;
            int ArraySize = GetUserArraySize(MaxArraySize);
            FillUserArray(ArraySize, out UserArray);
            PrintMin(UserArray);
            PrintMax(ref UserArray);
            Console.ReadKey();
        }

        static int GetUserArraySize(byte max)
        {
            int size = 0;
            do
            {
                Console.WriteLine("Define an array size and press Enter \nSize can be from 1 to "+max);
                size = Convert.ToInt32(Console.ReadLine());
            }
            while (size < 1);
            return (size);
        }

        static void FillUserArray(int size, out int[] array)
        {
            array = new int[size];
            Console.WriteLine("Fill the array via entering values from -2,147,483,648 to 2,147,483,647 \nPress Enter after each value.");
            for (int i = 0; i < size; i++)
            {
               array[i] = (Convert.ToInt32(Console.ReadLine()));
            }
        }

        static void PrintMin(int[] matrix)
        {
            int Min = matrix[0];
            for (int i = 1; i<(matrix.Length); i++)
            {
                if (matrix[i] < Min)
                {
                    Min = matrix[i];
                }
            }
            Console.WriteLine("Min value in your array is " + Min);
        }

        static void PrintMax(ref int[] matrix)
        {
            Console.WriteLine("Max value in your array is " + matrix.Max());
        }
    }
}
