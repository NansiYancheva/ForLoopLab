using System;
namespace Practice2602
{
    class Program
    {
        static void Main()
        {
            //Input
            int countOfInputs = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;
            //Actions
            for (int i =0; i < countOfInputs; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 ==0)
                    sumOne += currentNumber;
                else
                    sumTwo += currentNumber;
            }
            //Actions
            if (sumOne == sumTwo)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumOne}");
            }
            else
            {
                int difference = Math.Abs(sumOne - sumTwo);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {difference}");
            }


            //Output

        }
    }
}
