using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_Test
{
    class AboveBelow
    {
        // I chose a dictionary due to it being the closet thing I could find to a hash/map (key/value pairs)
        private Dictionary<string, int> answer = new Dictionary<string, int>(); // Holds our key/value pairs
        public Dictionary<string, int> GetAboveAndBelow(List<int> intCollection, int comparison)
        {
            Console.Write("Numbers to compare: ");  // Useful info for end user
            foreach (int collInt in intCollection)
            {
                Console.Write(collInt + " ");   // Writes numbers out so user can see
            }
            Console.WriteLine();    // Blank line
            Console.WriteLine("Number to compare to: " + comparison);   // Show user the comparison number

            //  This checks to make sure the comparison number is less than the largest number and greater than 
            //  for the smallest number, which would throw an exception
            if (comparison > intCollection.Max() || comparison < intCollection.Min())
            {
                Console.WriteLine("The comparison number must be between the lowest number and the highest number");    // Let user know error
                Console.ReadLine(); // Wait for input
                Environment.Exit(0);    //Exit
            }
            int numberAbove = 0;    // Holds amount of ints that are above the comparison
            int numberBelow = 0;    // Holds amount of ints below the comparison

            // This will iterate through the number list and decide whether the number is larger or smaller that the comparison number
            foreach (int collectionInt in intCollection)
            {
                if (collectionInt > comparison) // If the number is greater than the comparison
                {
                    numberAbove++;  // Increment number above
                }
                else if (collectionInt < comparison)    // If the number is less than the comparison
                {
                    numberBelow++;  // Increment number below
                }
                else
                {
                    // This means that the number has to be equal to the comparison itself. We do nothing here
                }
            }
            answer.Add("above", numberAbove);   // Add the above number to the dictionary
            answer.Add("below", numberBelow);   // Add the below number to the dictionary
            return answer;  // Return the dictionary to the method calling this method
        }
    }
}
