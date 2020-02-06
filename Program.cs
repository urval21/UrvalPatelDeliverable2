using System;

namespace UrvalPatelDeliverable2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What total score out of 100 you expect to get in ISM 4300? " + " Must not enter the % sign. ");

            int myNum = Convert.ToInt32(Console.ReadLine());

            if (myNum >=98 && myNum <=100)
            {
                Console.WriteLine("Your final grade is A+");   
            }

            else if (myNum >= 92 && myNum <= 97)
            {
                Console.WriteLine("Your final grade is A");
            }

            else if (myNum >= 90 && myNum <= 91)
            {
                Console.WriteLine("Your final grade is A-");
            }

            else if (myNum >= 88 && myNum <= 89)
            {
                Console.WriteLine("Your final grade is B+");
            }

            else if (myNum >= 82 && myNum <= 87)
            {
                Console.WriteLine("Your final grade is B");
            }

            else if (myNum >= 80 && myNum <= 81)
            {
                Console.WriteLine("Your final grade is B-");
            }

            else if (myNum >= 78 && myNum <= 79)
            {
                Console.WriteLine("Your final grade is C+");
            }

            else if (myNum >= 72 && myNum <= 77)
            {
                Console.WriteLine("Your final grade is C");
            }

            else if (myNum >= 70 && myNum <= 71)
            {
                Console.WriteLine("Your final grade is C-");
            }

            else if (myNum >= 68 && myNum <= 69)
            {
                Console.WriteLine("Your final grade is D+");
            }

            else if (myNum >= 62 && myNum <= 67)
            {
                Console.WriteLine("Your final grade is D");
            }

            else if (myNum >= 60 && myNum <= 61)
            {
                Console.WriteLine("Your final grade is D-");
            }

            else if (myNum < 60)
            {
                Console.WriteLine("Your final grade is F");
            }
            
            else
            {
                Console.WriteLine("Enter a value from 0 to 100");
            }
            
        }
    }
}
