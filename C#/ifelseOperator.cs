using System;

namespace ifelseOperator
{
    internal class Operator
    {
        static void Main(string[] args)
        {
            int num1, num2, ans, choice;

            Console.WriteLine("Enter num1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Addition\n2. Substraction\n3. Multiplication\n4. Division\n5. Exit");
            choice = Convert.ToInt32(Console.ReadLine());


            if(choice == 1 )
            {
                ans = num1 + num2;
                Console.WriteLine("Addition : " + ans);
            }
            else if(choice == 2)
            {
                ans = num1 - num2;
                Console.WriteLine("Substration : " + ans);
            }
            else if(choice == 3)
            {
                ans = num1 * num2;
                Console.WriteLine("Multiplication : " + ans);
            }
            else if(choice == 4)
            {
                ans = num1 / num2;
                Console.WriteLine("Division : " + ans);
            }
            else if(choice == 5)
            {
                Console.WriteLine("Exit");
            }
            Console.ReadKey();
        }

    }
}
