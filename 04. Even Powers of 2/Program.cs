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
            int num = 1;
           
            for (int i = 0; i <= number; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;

            }
                
            


            //Output



        }
    }
}