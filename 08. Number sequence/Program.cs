using System;
namespace Practice2602
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfInputs = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            //Actions
            for (int i = 0; i < numberOfInputs; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNumber)
                    maxNumber = currentNumber;
                if (currentNumber < minNumber)
                    minNumber = currentNumber;
            }

            //Output
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}

