using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RudTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Define an array size and press Enter \nSize can be from 1 to 255");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Fill the array via entering values from -2,147,483,648 to 2,147,483,647 \nPress Enter after each value.");
            array[0] = (Convert.ToInt32(Console.ReadLine()));
            object min = array[0];
            object max = array[0];
            for (int i = 1; i < size; i++)
            {
                array[i] = (Convert.ToInt32(Console.ReadLine()));
                if ((int)min > array[i])
                {
                    min = array[i];
                }
                if ((int)max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Min value in your array is " + min);
            Console.WriteLine("Max value in your array is " + max);
            Console.ReadKey();
        }
    }
}
