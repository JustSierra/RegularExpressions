using System;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            
            bool keepAsking = true;
            while (keepAsking)

            {
                Console.WriteLine("Enter a name");
                string userInfo = Console.ReadLine();
                if (userInfo == true)
                {
                    keepAsking = false;
                }
                else
                {
                    Console.WriteLine("That input is invalid, please try again");

                }

                string userNumber;
                while (keepAsking)
                {
                    Console.WriteLine("Enter a phone number in format xxx-xxx-xxxx");
                    string userNumber = Console.ReadLine();

                    if (userNumber == true)
                    {
                        Console.WriteLine(userNumber);
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid Input, please try again");
                    }


                }


 






            }
           




            
        }

    }
}
