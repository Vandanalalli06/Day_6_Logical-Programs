using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Prime
    {
        public void PrimeNumbers()
        {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("{0} is a Prime number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime number", num);
            }
        }
    }
}

//public void primeNumber()
//{
//    Console.WriteLine("Enter The Number");
//    int Num = Convert.ToInt32(Console.ReadLine());

//    int j = 0;

//    for (int i = 2; i < Num; i++)
//    {
//        if (Num % i == 0)
//        {
//            j = 1;
//            break;
//        }
//    }
//    if (j == 1)
//        Console.WriteLine(Num + "  Not a Prime Number");
//    else
//        Console.WriteLine(Num + "  Is a Prime Number");
