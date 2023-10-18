using System;


namespace doWhileSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            char choice ='y';

            do
            {
                Console.WriteLine("Enter num : ");
                num = Convert.ToInt32(Console.ReadLine());

                square = num * num;
                Console.WriteLine("Square is {0}", square);

                Console.WriteLine("Do you want to continue,Press y");
                choice = Convert.ToChar(Console.ReadLine());
            }
            while (choice == 'y');

            Console.ReadKey();
        }
    }
}
