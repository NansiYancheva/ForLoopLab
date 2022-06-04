using System;
namespace ForLoop
{
    class Program
    {
        static void Main()
        {
            //Input
            int number = int.Parse(Console.ReadLine());
            //Actions
            for (int i = 1; i <= number; i+=3)
            {
                Console.WriteLine(i);
            }


            //Output



        }
    }
}