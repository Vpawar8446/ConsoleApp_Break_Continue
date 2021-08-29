using System;

namespace ConsoleApp_Break_Continue
{
    class Conbre
    {
        public void Display(int n)
        {
            int i;
            for(i=0;i<=n;i++)
            {
                if (i > 1 && i<5)
                     continue;

                else if (i == 8)
                       break;
                
                Console.WriteLine("Value is " + i);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conbre obj = new Conbre();
            Console.Write("Enter the any number :");
            int num = Convert.ToInt32(Console.ReadLine());
            obj.Display(num);
        }
    }
}
