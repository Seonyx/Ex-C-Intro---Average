using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            Console.WriteLine("Enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            number1 = number1 + Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            number1 = number1 + Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 4");
            number1 = number1 + Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average of the four numbers is: {0}", number1 / 4);
        }
    }
}
