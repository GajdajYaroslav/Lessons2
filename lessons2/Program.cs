using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            int num = 0, tmp = 0, sum = 0, i = 0, j = 0;
            num = Convert.ToInt32(Console.ReadLine());
            tmp = num;
            while (tmp != 0)
            {
                tmp /= 10; ;
                i++;
            }
            Console.WriteLine("I= " + i);
            tmp = num;
            while (tmp != 0)
            {
                int temp = tmp % 10;
                if (temp % 2 == 0)
                {
                    sum += temp;
                }
                if (temp % 3 == 0)
                {
                    j++;
                }
                tmp /= 10;
            }
            Console.WriteLine("Sum= " + sum);
            Console.WriteLine("J= " + j);

            //2

            //Random rand = new Random();
            //bool f = false;
            //int num = -1, tmp = 0;
            //tmp = rand.Next(0, 100);
            //for (int i = 0; i < 5; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num == tmp)
            //    {
            //        f = true;
            //        break;
            //    }
            //    if (tmp > num)
            //    {
            //        Console.WriteLine("Warning!My number is bigger.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Warning!My number is small.");
            //    }
            //}
            //if (f)
            //{
            //    Console.WriteLine("You Win!");
            //}
            //else
            //{
            //    Console.WriteLine("Game Over!");
            //}
            //Console.WriteLine("Rand= " + tmp);

        }
    }
}