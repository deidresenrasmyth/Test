using System;

namespace ExamDeidre
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagToContinue = true;
            string resultString = "";
            int inputInt = 0;
            double input01Double = 0.0;
            double input02Double = 0.0;
            bool flagMult = true;
            DateTime date = new DateTime();
            string[] input = { "this", "is", "an", "array" };
            int[] input1 = { 1, 3, 6 };
            int[] input2 = { 2, 5, 4 };

            Console.WriteLine("Press anykey to execute Exercise 01");
            Console.ReadKey();
            GetMyInfo();

            flagToContinue = true;
            while (flagToContinue)
            {
                try
                {
                    Console.WriteLine("\nExercise 02");
                    Console.Write("Enter with a number: ");
                    inputInt = int.Parse(Console.ReadLine());
                    IsOddOrEven(inputInt);

                    flagToContinue = false;
                }
                catch
                {
                    Console.WriteLine("Some error was found, please do it again!");
                    flagToContinue = true;
                }
            }

            flagToContinue = true;
            while (flagToContinue)
            {
                try
                {
                    Console.WriteLine("\nExercise 03");
                    Console.Write("Enter with a string: ");
                    resultString = Console.ReadLine();
                    GetNumberOfCharacter(resultString);

                    flagToContinue = false;
                }
                catch
                {
                    Console.WriteLine("Some error was found, please do it again!");
                    flagToContinue = true;
                }
            }

            Console.WriteLine("\nPress ENTER to execute Exercise 04");
            Console.ReadKey();
            CountToFifteen();


            flagToContinue = true;
            while (flagToContinue)
            {
                try
                {
                    Console.WriteLine("\n\nExercise 05");
                    Console.Write("Enter with a double: ");
                    input01Double = double.Parse(Console.ReadLine());

                    Console.Write("Enter with a other double: ");
                    input02Double = double.Parse(Console.ReadLine());

                    Console.Write("Enter true for MULTIPLY or false to SUM: ");
                    if (Console.ReadLine().ToLower() == "false")
                    {
                        flagMult = false;
                    }
                    MultipliesOrSum(input01Double, input02Double, flagMult);

                    flagToContinue = false;
                }
                catch
                {
                    Console.WriteLine("Some error was found, please do it again!");
                    flagToContinue = true;
                }
            }

            flagToContinue = true;
            while (flagToContinue)
            {
                try
                {
                    Console.WriteLine("\nExercise 06");
                    Console.Write("Enter a valid date yyyy-mm-dd: ");
                    date = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine(DayOfeek(date));

                    flagToContinue = false;
                }
                catch
                {
                    Console.WriteLine("Some error was found, please do it again!");
                    flagToContinue = true;
                }
            }

            flagToContinue = true;
            while (flagToContinue)
            {
                try
                {
                    Console.WriteLine("\nExercise 07");
                    Console.Write("Enter with a number: ");
                    inputInt = int.Parse(Console.ReadLine());
                    gratterThan2000(inputInt);

                    flagToContinue = false;
                }
                catch
                {
                    Console.WriteLine("Some error was found, please do it again!");
                    flagToContinue = true;
                }
            }

            flagToContinue = true;
            while (flagToContinue)
            {
                try
                {
                    int input01, input02;
                    Console.WriteLine("\nExercise 08");
                    Console.Write("Enter with a number: ");
                    input01 = int.Parse(Console.ReadLine());
                    Console.Write("Enter with another number: ");
                    input02 = int.Parse(Console.ReadLine());
                    Console.WriteLine(checkNums(input01, input02));

                    flagToContinue = false;
                }
                catch
                {
                    Console.WriteLine("Some error was found, please do it again!");
                    flagToContinue = true;
                }
            }

            flagToContinue = true;
            while (flagToContinue)
            {
                try
                {
                    Console.WriteLine("\nExercise 09");
                    Console.Write("Enter with a string: ");
                    resultString = Console.ReadLine();
                    Console.WriteLine(LetterCapitalize(resultString));

                    flagToContinue = false;
                }
                catch
                {
                    Console.WriteLine("Some error was found, please do it again!");
                    flagToContinue = true;
                }
            }

            flagToContinue = true;
            while (flagToContinue)
            {
                try
                {
                    Console.WriteLine("\nExercise 10");
                    Console.Write("Enter with a number: ");
                    inputInt = int.Parse(Console.ReadLine());
                    Factorial(inputInt);

                    flagToContinue = false;
                }
                catch
                {
                    Console.WriteLine("Some error was found, please do it again!");
                    flagToContinue = true;
                }
            }

            Console.WriteLine("\n\nPress anykey to exit Final Test!");
            Console.ReadKey();
        }

        public static void GetMyInfo()
        {
            Console.WriteLine("Smyth Deidre " + DateTime.Now.ToString("yyyy-MM-dd hh:mm tt"));
        }

        public static void GetNumberOfCharacter(string input)
        {
            Console.WriteLine(input.Length);
        }

        public static void IsOddOrEven(int input)
        {
            if(input % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Even");
            }
        }

        public static void CountToFifteen()
        {
            int[] output = new int[15];
            for (int i = 0; i < 15; i++)
            {
                output[i] = i + 1;
            }
            for (int i = 0; i < 15; i++)
            {
                Console.Write(output[i] + " ");
            }
        }

        public static void MultipliesOrSum(double a, double b, bool flag)
        {
            if(flag == true)
            {
                Console.WriteLine(a * b);
            }
            else
            {
                Console.WriteLine(a + b);
            }
        }

        public static string DayOfeek(DateTime date)
        {
            return date.ToString("dddd");
        }

        public static void gratterThan2000(int input)
        {
            if(input > 2000)
            {
                Console.WriteLine("GRATTER THAN");
            }
            else
            {
                Console.WriteLine("LESS THAN");
            }
        }

        public static string checkNums(int a, int b)
        {
            if(b > a)
            {
                return "TRUE";
            }
            else
            {
                return "FALSE";
            }
        }

        public static string LetterCapitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            else
            {
                char[] a = input.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);
            }              
        }

        public static void Factorial(int input)
        {
            int result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
