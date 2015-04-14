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

            //call function with specific phrases
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could Bear Grylls grill if Bear Grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");

            // keep the console open
            Console.ReadKey();
        }
        public static string Disemvoweler(string input)
        {
            //create new string for the 'disemvoweled' text
            string disemvoweled = string.Empty;

            //create new string to contain the vowels removed
            string vowelsRemoved = string.Empty;

            //convert string input to lower case
            string temp = input.ToLower();

            //iterate through loop for each character in temp/input
            for (int i = 0; i < temp.Length; i++)
			{
                // check if vowel
                if ("aeiou".Contains(temp[i]))
                {
                    //add to vowel list
                    vowelsRemoved += temp[i];

                }
                
                //check if consonant
                else if ("bcdfghjklmnpqrstvwxyz".Contains(temp[i]))
                {
                    //add to disemvoweled list if char is consonant
                    disemvoweled += temp[i];
                }
                
                //handles spaces and special characters
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
