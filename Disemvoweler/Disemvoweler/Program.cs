using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {

            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could Bear Grylls grill if Bear Grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");

            // keep the console open
            Console.ReadKey();
        }
        public static string Disemvoweler(string input)
        {
            string disemvoweled = string.Empty;
            string vowelsRemoved = string.Empty;
            string temp = input.ToLower();

            for (int i = 0; i < input.Length; i++)
			{
                if ("aeiou".Contains(temp[i]))
                {
                    vowelsRemoved += temp[i];

                }
                else if ("bcdfghjklmnpqrstvwxyz".Contains(temp[i]))
                {
                    disemvoweled += temp[i];
                }
                else
                {

                }
            }
           
            // Write out the various string results
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + disemvoweled);
            Console.WriteLine("Vowels Removed: " + vowelsRemoved);
            Console.WriteLine();
            // Return the Disemvoweled string as well for testing
            return disemvoweled;
        }
    }
}
