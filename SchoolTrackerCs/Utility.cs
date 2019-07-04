using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolTrackerCs
{
    class Utility
    {
        //ReadLine and WriteLine function
        static public string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        //Failsafe function force input to int

        static public int AskInt(string question)
        {
            bool loopState = true;
            int result = 0;
            System.Console.WriteLine(question);

            do
            {
                if (int.TryParse(System.Console.ReadLine(), out int output))
                {
                    result = output;
                    loopState = false;
                }
                else
                {
                    System.Console.WriteLine("value must be a number, please try again");
                }

            } while (loopState);

            return result;
        }

        static public decimal AskDecimal(string question)
        {

            bool loopState = true;
            decimal answer = 0;
            System.Console.WriteLine(question);
            do
            {

                if (decimal.TryParse(System.Console.ReadLine(), out decimal result))
                {
                    answer = result;
                    loopState = false;
                    break;
                }
                else
                {
                    System.Console.WriteLine("Try again");
                }

                System.Console.WriteLine(question);
            } while (loopState);


            return answer;
        }

        //Failsafe and force input to be chars only
        /// <summary>
        /// https://stackoverflow.com/questions/1181419/verifying-that-a-string-contains-only-letters-in-c-sharp
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static public string AskString(string question)
        {
            System.Console.WriteLine(question);

            string answer;
            bool loopState = true;
            do
            {
                answer = System.Console.ReadLine();
                if (answer.All(Char.IsLetter))
                {
                    loopState = false;

                }
                else
                {
                    System.Console.WriteLine("Please try again");
                }


            } while (loopState);

            return answer;

        }

        //Failsafe and force input to be chars only without numbers

        static public string ExcludeSymbols(string question, char[] noneAllowedSymbols)
        {
            System.Console.WriteLine(question);
            string answer;
            bool loopState = true;
            int symbolCount = 0;

            do
            {
                answer = System.Console.ReadLine();
                foreach (char element in noneAllowedSymbols)
                {
                    for (int index = 0; index < answer.Length; index++)
                    {
                        if (answer[index] == element)
                        {
                            symbolCount++;
                            break;
                        }
                    }
                }
                if (symbolCount > 0)
                {
                    System.Console.WriteLine("Try again");
                    symbolCount = 0;
                }
                else if (symbolCount == 0)
                {
                    loopState = false;
                }


            } while (loopState);


            return answer;
        }

        static public string CheckStringForElementV2(string question, char[] noneAllowedSpecials)
        {
            System.Console.WriteLine(question);

            string answer;
            int specialsCount = 0;
            bool loopState = true;
            do
            {
                answer = System.Console.ReadLine();
                foreach (char element in noneAllowedSpecials)
                {
                    for (int index = 0; index < answer.Length; index++)
                    {
                        if (answer[index] == element)
                        {
                            specialsCount++;
                            break;
                        }
                    }
                }

                if (specialsCount > 0)
                {
                    System.Console.WriteLine("Please try again");
                    specialsCount = 0;
                }
                else
                {
                    loopState = false;
                }


            } while (loopState);


            return answer;
        }

        static public string CheckStringForElementV3(string question, char[] noneAllowedSpecials)
        {
            System.Console.WriteLine(question);
            string answer;
            bool loopState = true;
            int errorCount = 0;
            do
            {
                answer = System.Console.ReadLine();
                foreach (char element in noneAllowedSpecials)
                {
                    for (int index = 0; index < answer.Length; index++)
                    {
                        if (answer[index] == element)
                        {
                            errorCount++;
                            break;
                        }
                    }
                }

                if (errorCount > 0)
                {
                    System.Console.WriteLine("try again");
                    errorCount = 0;
                }
                else
                {
                    loopState = false;
                }

            } while (loopState);

            return answer;
        }

        static public string CheckStringForElementV4(string question, char[] NoneAllowedSpecials)
        {
            System.Console.WriteLine(question);

            string answer;
            bool loopState = true;
            int errorCount = 0;

            do
            {
                answer = System.Console.ReadLine();
                foreach (char element in NoneAllowedSpecials)
                {
                    for (int index = 0; index < answer.Length; index++)
                    {
                        if (answer[index] == element)
                        {
                            errorCount++;
                            break;
                        }
                    }
                }

                if (errorCount > 0)
                {
                    System.Console.WriteLine("Please try again");
                    errorCount = 0;

                }
                else
                {
                    loopState = false;
                }

            } while (loopState);


            return answer;
        }

        static public string CheckStringForElementV5(string question, char[] NoneAllowedSymbols)
        {
            System.Console.WriteLine(question);

            bool loopState = true;
            string answer;
            int errorCount = 0;
            do
            {
                answer = Console.ReadLine();
                foreach (char elements in NoneAllowedSymbols)
                {
                    for (int index = 0; index < answer.Length; index++)
                    {
                        if (answer[index] == elements)
                        {
                            errorCount++;
                            break;
                        }                      
                    }
                }

                if (errorCount>0)
                {
                    errorCount = 0;
                    Console.WriteLine("Please try again");
                }
                else
                {
                    loopState = false;
                }


            } while (loopState);

            return answer;
        }

        static public string RequiredSymbols(string question, char[] requiredSymbols)
        {
            System.Console.WriteLine(question);
            string answer;
            bool loopState = true;
            int errorCount = 0;
            do
            {
                answer = System.Console.ReadLine();
                foreach (char element in requiredSymbols)
                {
                    for (int index = 0; index < answer.Length; index++)
                    {
                        if (answer[index] == element)
                        {
                            errorCount++;

                        }
                    }
                }

                if (errorCount == 1)
                {
                    loopState = false;
                }
                else
                {
                    errorCount = 0;
                    System.Console.WriteLine("input is not a valid email please try again");
                }

            } while (loopState);

            return answer;
        }

        static public string ValidateEmail(string question)
        {
           
            bool loopState = true;
            char[] emailSymbols = {'@','.'};
            int match = 0;
            string answer;

            Console.WriteLine(question);
            

            do
            {
                answer = Console.ReadLine();

                foreach (char element in emailSymbols)
                {
                    for (int index = 0; index < answer.Length; index++)
                    {
                        if (answer[index] == element )
                        {
                            match++;
                            Console.WriteLine("Match");

                        }                
                    }
                }

                if (match == 2)
                {
                    loopState = false;
                }
                else
                {
                    match = 0;
                    Console.WriteLine("input not an email, please try again");
                    
                } 

            } while (loopState);

            return answer;

        }


    }
}

