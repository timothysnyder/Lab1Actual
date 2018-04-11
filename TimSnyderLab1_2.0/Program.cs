using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSnyderLab1_2._0
{
    class Program
    {
        static void Main(string[] args)

        {

            while (true)

            {



                Console.WriteLine("Please Enter Three Digit Number");

                string one = Console.ReadLine();

                bool TestInputOne = int.TryParse(one, out int FirstInput);

                Console.WriteLine("Please Enter Another Three Digit Number");

                string two = Console.ReadLine();



                Console.WriteLine(CompareInputs(one, two));

                Console.WriteLine("Press Enter to end.");

                Console.ReadLine();

                return;

            }

        }

        private static bool CompareInputs(string one, string two)

        {

            //Validate the inputs are numbers

            if (!int.TryParse(one, out int numberOne))

            {

                Console.WriteLine("The first entry, " + one + " is not a number.");

                return false;

            }

            if (!int.TryParse(two, out int numberTwo))

            {

                Console.WriteLine("The second entry, " + two + " is not a number.");

                return false;

            }

            //Validate length

            if (one.Length < 2 || two.Length < 2)

            {

                Console.WriteLine("One of the numbers entered is less than 10.");

                return false;

            }

            //One all validations pass, create our Results Array

            //Note this time I'm taking an alternate approach, not creating arrays but rather substringing the strings entered then converting those positions to ints

            int lengthOfInputs = one.Length;

            int[] ResultsArray = new int[lengthOfInputs];



            for (int i = 0; i < lengthOfInputs; i++)

            {

                ResultsArray[i] = Convert.ToInt32(one.Substring(i, 1)) + Convert.ToInt32(two.Substring(i, 1));

            }

            //Now, just compare the numbers in the Results Array

            //Note:  We're doing the length of the inputs - 1 here to prevent overflow since we'll be

            //             adding to the NEXT array entry in the loop

            for (int j = 0; j < lengthOfInputs - 1; j++)

            {

                if (ResultsArray[j] != ResultsArray[j + 1])

                {

                    return false;

                }

            }

            //If we get all the way here, all the numbers were equal

            return true;

        }







    }

}


