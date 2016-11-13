using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RudTask2
{
    class RudTask2
    {
        static void Main()
        {
            for (int i=1; i <= 100; i++)                            //Check each number from 1 to 100
            {
                Console.WriteLine(FizzBuzzNumber(i));               //Get and print FizzBuzz results
            }
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }

        static string FizzBuzzNumber(int FizzBuzzCandidate)         //FizzBuzz numbers finding method
        {
            string ResultPrint = "";                                
            if (FizzBuzzCandidate % 3 == 0)                         //Add Fizz if current number is multiple for 3
                ResultPrint = "Fizz";
            if (FizzBuzzCandidate % 5 == 0)
                ResultPrint += "Buzz";                              //Add Buzz if current number is multiple for 5
            if (ResultPrint == "")
                ResultPrint = Convert.ToString(FizzBuzzCandidate);  //Put current number to the result if it is still empty
            return (ResultPrint);
        }
    }
}
