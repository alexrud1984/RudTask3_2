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
            int CustomerValue = 0;
            int CustomerDivider = 0;
            Console.Write("Hello! Enter your Value and press Enter.\n");
            CustomerValue=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter possible divider for the Value and press Enter.\n");
            CustomerDivider= Convert.ToInt32(Console.ReadLine());
            if (Convert.ToBoolean(CustomerValue % CustomerDivider))
                Console.WriteLine("The "+ CustomerDivider+ " is not divider for the "+ CustomerValue);
            else Console.WriteLine("The "+ CustomerDivider+ " is divider for the "+ CustomerValue);
            Console.Read();
        }
    }
}
