using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogicaProgramsl
{
    public class Armstron
    {
        public void Armstrong()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
           temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}  
