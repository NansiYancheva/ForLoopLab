using System;
namespace Practice2602
{
    class Program
    {
        static void Main()
        {
            //Input
            string word = Console.ReadLine();
           int sumOfLetters = 0;
            //Actions
            int lenghofWord = word.Length;
            for (int i = 0; i <= lenghofWord - 1; i++)
            {
                char currentLetter = word[i];
                switch (currentLetter)
                {
                    case 'a':
                        sumOfLetters++;
                        break;
                    case 'e':
                        sumOfLetters +=2;
                        break;
                    case 'i':
                        sumOfLetters +=3;
                        break;
                    case 'o':
                        sumOfLetters +=4;
                        break;
                    case 'u':
                        sumOfLetters +=5;
                        break;
                }

            }
            Console.WriteLine(sumOfLetters);


            //Output

        }
    }
}
