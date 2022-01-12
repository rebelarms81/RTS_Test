using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAboveAndBelow(); // Tests get above and below
            RotateString(); // Tests rotate string
        }

        public static void GetAboveAndBelow()
        {
            AboveBelow aboveBelow = new AboveBelow();
            List<int> numList = new List<int>() { 5, 96, 15, 48, 3, 101 };
            Dictionary<string, int> answer = new Dictionary<string, int>();
            answer = aboveBelow.GetAboveAndBelow(numList, 51);
            foreach (var dictAnswer in answer)
            {
                Console.WriteLine(dictAnswer.ToString());
            }
            Console.ReadLine();
        }

        public static void RotateString()
        {
            string returnedString = string.Empty;
            StringRotate rotate = new StringRotate();
            returnedString = rotate.RotateString("MyString", 10355);
            Console.WriteLine("The new string is: " + returnedString);    // Write the answer
            Console.ReadLine(); // Wait for input to exit

        }
    }
}
