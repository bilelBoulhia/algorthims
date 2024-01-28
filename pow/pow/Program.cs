using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 2;
            int n = -3;
            double result = x;




            if (n == 0 || x == 1) { result = 1; } else if (n == 2147483648 || n == -2147483648) { result = Math.Pow(x, n); }


            else if (n.ToString().Contains('-'))
            {

                for (int i = 1; i < n * -1; i++)
                {
                    result *= x;
                }
                result = 1 / result;
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    result *= x;
                }


            }














                Console.WriteLine(result);



                Console.ReadKey();






            }

        


    }
}
