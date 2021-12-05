using System;

namespace ToUpperOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please enter you string:");
            string userInput = Console.ReadLine();
            //Console.WriteLine(userInput.Length);
            Random rnd = new Random();
            string userOutput = "";

            //Console.WriteLine(userInput[2]);
            for (int i = 0; i < userInput.Length; i++)
            {
                int ran = rnd.Next(1, 3);

                if (ran == 1)
                {
                    userOutput += char.ToUpper(userInput[i]);
                    //userOutput += userInput[i].ToString().ToUpper();

                }
                else
                {
                    userOutput += char.ToLower(userInput[i]);
                }
            }

            /*          foreach (var item in userInput)
                      {
                         int ran = rnd.Next(1, 3);

                         if (ran == 1)
                         {
                                userOutput += char.ToUpper(item);
                                //userOutput += userInput[i].ToString().ToUpper();

                         }
                            else
                         {
                                userOutput += char.ToLower(item);
                         }

                      }*/

            Console.WriteLine(userOutput);
            //Console.WriteLine(userOutput.ToUpper());
        }
    }
}
