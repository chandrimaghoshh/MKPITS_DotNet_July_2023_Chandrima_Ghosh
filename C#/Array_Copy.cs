using System;

namespace Array_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            for(int cnt=0; cnt<3; cnt++)
            {
                Console.WriteLine("Enter number : ");
                arr1[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            for(int cnt=0; cnt<3;cnt++)
            {
                Console.WriteLine("element {0} - {1} ", num[cnt],cnt);
            }
            Console.WriteLine("The elements stored in the first array are :");
            for(int cnt=0; cnt<3; cnt++)
            {
                
                Console.Write("{0} ", cnt);
            }
            Console.WriteLine("The elements copied into the second array are :");
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if(arr1[i] == arr2[j])
                }
            }
            Console.ReadKey();
        }
    }
}
