using System;
namespace ForLoop
{
    class Program
    {
        static void Main()
        {
            //Input
            int countNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            //Actions
            for (int i = 1; i <= countNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);



            //Output




        }
    }
}
