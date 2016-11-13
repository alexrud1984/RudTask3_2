using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RudTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int CustomerValue, CustomerDivider = 0;

            //Get customer data
            Console.Write("Hello! Insert your Value and press Enter.\n");
            CustomerValue=Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert possible divider for the "+ CustomerValue+" and press Enter.\n");
            CustomerDivider= Convert.ToInt32(Console.ReadLine());

            //Check if CustomerDivider is divider for CustomerValue
            if (CustomerValue % CustomerDivider)
                Console.WriteLine("The "+ CustomerDivider+ " is not divider for the "+ CustomerValue);
            else Console.WriteLine("The "+ CustomerDivider+ " is divider for the "+ CustomerValue);

            Console.Write("Press Enter for exit.");
            Console.Read();
        }
    }
}
