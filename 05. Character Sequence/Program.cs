using System;
namespace ForLoop
{
    class Program
    {
        static void Main()
        {
            //Input
            string word = Console.ReadLine();
            //Actions
            int lenght = word.Length;
            for (int i = 0; i <= lenght - 1; i++)
            {
                char currentChar = word[i];
                Console.WriteLine(currentChar);
            }


            //Output




        }
    }
}
