using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade in percentage (Please do not include the % symbol)? ");
            string response = Console.ReadLine();
            int percentage_value = int.Parse(response);

            string letter = "";
            string plus_or_minus = "";

            if (percentage_value >= 90)
            {
                letter = "A";
            }
            else if (percentage_value >= 80)
            {
                letter = "B";
            }
            else if (percentage_value >= 70)
            {
                letter = "C";
            }
            else if (percentage_value >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Determine whether to append + or - to the grade letter

            if ((percentage_value % 10 >= 7) && (percentage_value >= 90)) //Recognize that there is no A+ grade, only A and A-
            {
                plus_or_minus = "";
            }

           
            // Recognize that there is no F+ or F- grades, only F
            else if ( ((percentage_value % 10 >= 7) || (percentage_value % 10 < 3)) && (percentage_value <= 59) )
            {
                plus_or_minus = "";
            }

           


            else if (percentage_value % 10 >= 7)
            {
                plus_or_minus = "+";
            }



            else if (percentage_value % 10 < 3)
            {
                plus_or_minus = "-";
            }


       

            else
            {
                plus_or_minus = "";
            }

            Console.WriteLine($"Your grade is: {letter} {plus_or_minus}");

            if (percentage_value >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}
