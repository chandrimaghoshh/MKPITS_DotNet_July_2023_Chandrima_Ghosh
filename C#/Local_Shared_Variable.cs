using System;


namespace Local_Shared_Variable
{
    class Program
    {
        static int num = 20;
        static void display()
        {
            int num = 10;
            Console.WriteLine("num inside method : "+num);
        }
        static void Main(string[] args)
        {
            display();
            int num = 20;
            Console.WriteLine("Num shared : " + num);

            Console.ReadKey();
        }
    }
}
