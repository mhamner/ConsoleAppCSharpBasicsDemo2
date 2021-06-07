using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpBasicsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo string operations
            string s = "Mark";
            Console.WriteLine(s);

            int i = 10;
            Console.WriteLine(i.ToString());

            //Demo math operations
            int j = 10;
            int k = 25;

            int answer = j * k;
            Console.WriteLine(answer.ToString());

            int answer2 = j + k;
            Console.WriteLine(answer2.ToString());

            int answer3 = k - j;
            Console.WriteLine(answer3.ToString());

            //Order of operations example:  This will give 13
            int answer4 = (5 * 2) / 2 + 8;
            Console.WriteLine(answer4.ToString());

            //Loop examples
            Console.WriteLine("** Loops **");
            for(int m=0; m<10;m++)
            {
                Console.WriteLine(m.ToString());
            }

            string[] avengerArray = { "Iron Man", "Thor", "Captain Marvel", "Captain America (Steve)", "Captain America (Sam)" };
            foreach(string avenger in avengerArray)
            {
                Console.WriteLine("Foreach loop: " + avenger);
            }

            int t = 0;
            while(t<10)
            {
                t++;
                Console.WriteLine("While Loop: " + t.ToString());
            }

            int p = 0;
            do
            {
                p++;
                Console.WriteLine("Do While Loop: " + p.ToString());
            } while (p < 10);

            //Do While example showing you get at least one execution of the loop no matter what
            int b = 99;
            do
            {
                b++;
                Console.WriteLine("Do While Loop Example Two: " + b.ToString());
            } while (b < 10);

            //If / Else Examples
            Console.WriteLine("** If / Else Examples **");
            int ab = 100;
            if(ab > 50)
            {
                Console.WriteLine($"{ab.ToString()} is greater than 50!");
            }

            if(ab < 50)
            {
                Console.WriteLine($"{ab.ToString()} is less than 50!");
            }
            else
            {
                Console.WriteLine($"{ab.ToString()} is not less than 50!");
            }

            //Notice that we exit after the first else if, even though the last one also matches!
            if (ab < 50)
            {
                Console.WriteLine($"{ab.ToString()} is less than 50!");
            }
            else if(ab > 70)
            {
                Console.WriteLine($"{ab.ToString()} is greater than 70!");
            }
            else if (ab > 80)
            {
                Console.WriteLine($"{ab.ToString()} is greater than 80!");
            }

            //Switch / Case example
            Console.WriteLine("** Switch / Case **");
            string color = "orange";
            switch(color)
            {
                case "red":
                    Console.WriteLine("The color is red!");
                    break;
                case "orange":
                    Console.WriteLine("The color is orange!");
                    break;
                case "blue":
                    Console.WriteLine("The color is blue!");
                    break;
                case "green":
                    Console.WriteLine("The color is green!");
                    break;
                default:
                    Console.WriteLine("Cannot determine color.");
                    break;
            }

            //Demo of why you shouldn't use default to mean "the other value" - here let's assume the color SHOULD be eithe red or blue, but it's not.
            //  This leads to a misleading message sent to the user!
            string color2 = "orange";
            switch (color2)
            {
                case "red":
                    Console.WriteLine("The color is red!");
                    break;
                default:
                    Console.WriteLine("The color is blue!");
                    break;
            }

            //Demo of Try / Catch

            //Uncomment to show how this throws a run time error
            //int[] numberArray1 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numberArray1[10]);

            Console.WriteLine("** Try / Catch **");
            int[] numberArray1 = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(numberArray1[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Encountered: {ex.Message}");           
            }

            //Demo of adding "finally"
            Console.WriteLine("** Try / Catch **");
            int[] numberArray2 = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(numberArray2[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Encountered: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("All done here!");
            }

            //Demo of using "throw" to throw a specific error class - uncomment the throw to demo it
            Console.WriteLine("** Try / Catch **");
            int[] numberArray3 = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(numberArray3[10]);
            }
            catch (Exception ex)
            {
                //throw new FormatException("This is a format exception!");
            }
            finally
            {
                Console.WriteLine("All done here!");
            }

            Console.ReadKey();
        }      

    }
}
