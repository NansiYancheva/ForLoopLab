using System;
namespace Practice2602
{
    class Program
    {
        static void Main()
        {
            //Input
            int countsOfInput = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;
            for (int i = 0; i < 2 * countsOfInput; i++)
            {
                int currentNumberOne = int.Parse(Console.ReadLine());
                if (i < countsOfInput)
                    sumOne+=currentNumberOne;
                else
                    sumTwo +=currentNumberOne;
                
            }
            //Actions
            if (sumOne == sumTwo)
                Console.WriteLine($"Yes, sum = {sumOne}");
            else
                {
                int difference = Math.Abs(sumOne - sumTwo);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
