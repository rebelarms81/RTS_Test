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
            Console.WriteLine("String to rotate: " + stringToRotate + " (string length: " + stringToRotate.Length + ")");   // Shows string that we are rotating
            Console.WriteLine("Number to rotate by: " + numberToRotateBy);    // Shows number to rotate by

            // We use modulo here to get the remainder of dividing the int to rotate by the length of the string
            // Essentially, we don't care about how many times the letters need to shift, only how many letters need to shift 
            // for the remainder
            numberToRotateBy = numberToRotateBy % stringToRotate.Length;
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
