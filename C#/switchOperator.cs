using System;

namespace switchOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, num1, num2, res;

            Console.WriteLine("Enter num1 & num2 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Addition\n2. Substraction\n3. Multiplication\n4. Division\n5. Exit");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    res = num1 + num2;
                    Console.WriteLine("Adiition = " + res);
                    break;

                case 2:
                    res = num1 - num2;
                    Console.WriteLine("Substraction is = " + res);
                    break;

                case 3:
                    res = num1 * num2;
                    Console.WriteLine("Multiplication is = " + res);
                    break;
                case 4:
                    res = num1 / num2;
                    Console.WriteLine("Division is = " + res);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
