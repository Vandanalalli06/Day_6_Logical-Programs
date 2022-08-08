using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumberProblem
    {
        public void PerfectNumber()
        {
            int num, n;
            int sum = 0;

            Console.WriteLine("Enter the number to check the Perfect number");
            num = Convert.ToInt32(Console.ReadLine());
            n = num;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }

            }

            if (sum == n)
            {
                Console.WriteLine("number is Perfect number");
            }
            else
            {
                Console.WriteLine("number is not Perfect number");
            }
        }
    }
}
