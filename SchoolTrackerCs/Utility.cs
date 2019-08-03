using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

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
        // Method to check the CPR first 6 digits 
        static public string CPR(string question)
        {
            string _varConfirmedCPR = "";   
            bool loopState = true;

            DateTime _varConvertConfirmedCPR = new DateTime();
      
            do
            {
                Console.WriteLine(question);
                string checkCPR = Console.ReadLine();

                if (checkCPR.Length == 10)
                {
                    
                    _varConfirmedCPR = checkCPR;

                    _varConfirmedCPR = _varConfirmedCPR.Insert(2, "/");
                    _varConfirmedCPR = _varConfirmedCPR.Insert(5, "/");
                    _varConfirmedCPR = _varConfirmedCPR.Insert(8, "/");
             
                    
                    if (DateTime.TryParse(_varConfirmedCPR.Substring(0,8), out _varConvertConfirmedCPR))
                    {
                      
                        loopState = false;
                    }
                    else
                    {
                        Console.WriteLine("Not valid try again");
                    }
                   
                   
                }
                else
                {
                    Console.WriteLine("PLease try again");
                }
                
            } while (loopState);

            return _varConfirmedCPR;

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
            int emailPosition = 0;
            int periodPosition = 0;
            int match = 0;
            string email;
            

            Console.WriteLine(question);
           

            do
            {
                email = Console.ReadLine();

                foreach (char element in emailSymbols)
                {
                    for (int index = 0; index < email.Length; index++)
                    {
                        if (index -1 >= 0 && !email.EndsWith("@") && !email.EndsWith(".") && !email.Contains(' ') && email.Contains(".") && !email.StartsWith(".")) // To bypass the "index is out of bound array issue
                        {
                            if (email[index] == element && char.IsLetterOrDigit(email[index -1]) && !char.IsPunctuation(email[index +1]))
                            {
                                match++;
                                
                            }

                            if (email[index] == emailSymbols[0])
                            {
                                emailPosition = index;
                            }

                            if (email[index] == emailSymbols[1])
                            {
                                periodPosition = index;
                            }
                        }                   
                    }
                    if (match == 0)
                    {
                        break;
                    }
                }

                if (match >= 1 && periodPosition > emailPosition)
                {
                    loopState = false;
                    return email;
                }
                else
                {                   
                    Console.WriteLine("input not an email, please try again");
                    loopState = true;
                } 

            } while (loopState);

            return email;
        }


    }
}

