using System;

namespace SECTION
{
    class FCI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int FIRSTNUMBER= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Second number");
            int SECONDNUMBER = int.Parse(Console.ReadLine());
            int i, sum;
            for(int n=FIRSTNUMBER;n<=SECONDNUMBER;n++)
            {
                i = 1;
                sum = 0;
                while(i<n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0}", n);

            }
            Console.ReadKey();

        }
    }
}
