using System;
using System.Text;

namespace FirstProject
{
    #region ProgramClassRegion
    class Program 
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int? max = null;

            Console.WriteLine("To exit type \"0\"");
            Console.WriteLine("Type in your number: ");
            int number = int.Parse(Console.ReadLine());
                
            while(number != 0)
            {
                if(max == null || number > max)
                {
                    max = number;
                }
                sum += number;

                Console.WriteLine("Type in your number: ");
                number = int.Parse(Console.ReadLine());
            }

            if (max == null)
            {
                Console.WriteLine("You exit a program without typing any number");
            }
            else
            {
                Console.WriteLine("You exit a program ");
                Console.WriteLine("Input summary is " + sum);
                Console.WriteLine("Input maximum is " + max);
            }

        }
    }

    #endregion

}
