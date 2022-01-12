using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_Test
{
    class StringRotate
    {
        public string RotateString(string stringToRotate, int numberToRotateBy)
        {
            // Checks to see if number to rotate by is less than the string length. If it is greater, let the user know and exit
            if (numberToRotateBy > stringToRotate.Length)
            {
                Console.WriteLine("The number must be greater than zero and less than the number of letters in the string to rotate ({0})",stringToRotate.Length);
                Console.ReadLine(); // Wait for user to press a button
                Environment.Exit(0);// Exit
            }
            Console.WriteLine("String to rotate: " + stringToRotate);   // Shows string that we are rotating
            Console.WriteLine("Number to rotate by: " + numberToRotateBy);    // Shows number to rotate by
            string stringAnswer = string.Empty; // Holds our answer
            string tempString = string.Empty;   // Holds a temp string to work with
            int lengthOfString = stringToRotate.Length; // var to hold string length

            // if we concatenate the stringToRotate to itself, we can use a substring of the resulting string to make it
            // appear that we have shifted the letters to the right
            tempString = stringToRotate + stringToRotate; // Concat the string to itself

            // Substring the length of stringToRotate - toRotateBy. Then use the length of the original stringToRotate to find the end 
            // of our newly "rotated" string. Example: MyStri|ngMyStri|ng
            stringAnswer = tempString.Substring(lengthOfString - numberToRotateBy, lengthOfString);
            return stringAnswer;
        }
    }
}
