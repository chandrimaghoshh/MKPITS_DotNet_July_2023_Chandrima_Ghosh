using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    public class Calculator
    {
        // Properties
        public double Result = 4;

        // Methods

        // Addition
        public void Add(double num)
        {
            Result += num;
        }

        // Subtraction
        public void Subtract(double num)
        {
            Result -= num;
        }

        // Multiplication
        public void Multiply(double num)
        {
            Result *= num;
        }

        // Division
        public void Divide(double num)
        {
            if (num != 0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
        }
        // Exponentiation
        public void Exponentiate(double exponent)
        {
            Result = Math.Pow(Result, exponent);
        }

        // Square root
        public void SquareRoot()
        {
            if (Result >= 0)
            {
                Result = Math.Sqrt(Result);
            }
            else
            {
                Console.WriteLine("Error: Cannot calculate square root of a negative number.");
            }
        }

        // Clear the calculator result
        public void Clear()
        {
            Result = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Current Result: " + myCalculator.Result);
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exponentiate");
                Console.WriteLine("6. Square Root");
                Console.WriteLine("7. Clear");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter number to add: ");
                        double addNum = Convert.ToDouble(Console.ReadLine());
                        myCalculator.Add(addNum);
                        break;

                    case "2":
                        Console.Write("Enter number to subtract: ");
                        double subNum = Convert.ToDouble(Console.ReadLine());
                        myCalculator.Subtract(subNum);
                        break;

                    case "3":
                        Console.Write("Enter number to multiply: ");
                        double mulNum = Convert.ToDouble(Console.ReadLine());
                        myCalculator.Multiply(mulNum);
                        break;

                    case "4":
                        Console.Write("Enter number to divide: ");
                        double divNum = Convert.ToDouble(Console.ReadLine());
                        myCalculator.Divide(divNum);
                        break;

                    case "5":
                        Console.Write("Enter exponent: ");
                        double exponent = Convert.ToDouble(Console.ReadLine());
                        myCalculator.Exponentiate(exponent);
                        break;

                    case "6":
                        myCalculator.SquareRoot();
                        break;

                    case "7":
                        myCalculator.Clear();
                        break;

                    case "8":
                        Console.WriteLine("Exiting the calculator. Goodbye!");
                        Environment.Exit(8);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine(); // Add a newline for better readability
                Console.ReadKey();
            }
        }
    }
}
