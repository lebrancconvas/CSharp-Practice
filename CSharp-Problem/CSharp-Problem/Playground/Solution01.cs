using System;
namespace CSharp_Problem.Playground
{
    public class Solution01
    {
        public Solution01()
        {
            String numberterminal;
            String numberconcat = "";

            Console.WriteLine("Enter Your Number: ");
            numberterminal = Console.ReadLine();

            int number = Convert.ToInt16(numberterminal);

            for (int i = 1; i <= number; i++)
            {
                numberconcat += i;
            }

            Console.WriteLine(numberconcat);
        }
    }
}
