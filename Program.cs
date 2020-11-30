using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8_Ball
{
    class Program
    {

        //create randomizer object
        static Random randomThing = new Random();
        static void Main(string[] args)
        {
            //preserve original console text color
            ConsoleColor oldColor = Console.ForegroundColor;

            StartProgram();

            while (true)
            {

                string userQuestion = GetQuestionFromUser();

                if (userQuestion.Length == 0)
                {
                    Console.WriteLine("I cannot help you if you do not ask a question!");
                    continue;
                }

                if (userQuestion.ToLower() == "q")
                {
                    break;
                }

                //simulates thinking
                int secondsToSleep = ((randomThing.Next(5) + 1) * 1000);
                Console.WriteLine("Thinking, stand by...");
                Thread.Sleep(secondsToSleep);

                //gets response
                EightBallResponses();

            }

            // cleaning up
            Console.ForegroundColor = oldColor;

        }


        static void StartProgram()
        {
            //change console text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Magic 8 Ball!");
            Console.WriteLine("(Press 'Q' at any time to quit the program)");
        }


        static string GetQuestionFromUser()
        {
            //asks user for question and stores in a variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask me a question: ");
            string userQuestion = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            

            return userQuestion;
        }


        //uses random to generate responses
        static void EightBallResponses()
        {
            int randomNumber = randomThing.Next(19);
            switch (randomNumber)
            {
                case 0:
                    {
                        Console.WriteLine("As I see it, yes.");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Ask again later.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Better not tell you now.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Cannot predict now.");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Concentrate and ask again.");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Don't count on it.");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("It is certain.");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("It is decidedly so.");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Most likely.");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("My reply is no.");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("My sources say no.");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Outlook not so good.");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Outlook good.");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("Reply hazy, try again.");
                        break;
                    }

                case 14:
                    {
                        Console.WriteLine("Signs point to yes.");
                        break;
                    }

                case 15:
                    {
                        Console.WriteLine("Very doubtful.");
                        break;
                    }

                case 16:
                    {
                        Console.WriteLine("Without a doubt.");
                        break;
                    }

                case 17:
                    {
                        Console.WriteLine("Yes.");
                        break;
                    }


                case 18:
                    {
                        Console.WriteLine("Yes - definitely.");
                        break;
                    }
                case 19:
                    {
                        Console.WriteLine("You may rely on it.");
                        break;
                    }
            }
        }


    }
}

