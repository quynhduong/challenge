using System;
using System.Linq;

namespace test
{
    public class Program
    {
        public static ExtractNumber extract = new ExtractNumber();
        static void Main(string[] args)
        {
            while(!Console.KeyAvailable)
            {
                Console.WriteLine("Please input your string: ");

                //Input a string
                string input = Console.ReadLine();
             
                // Output is an interger
                int output = extract.extractnumber(input);

                Console.WriteLine("Output  = " + output);


            }

        }

    }

    
}
