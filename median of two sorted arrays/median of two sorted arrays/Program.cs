using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace median_of_two_sorted_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num1 = { 4, };
            int[] num2 = {3,  1,2 };
            double result = 0;
            int m = 0;
            int m1 = 0;




            int[] Aint = new int[num1.Length + num2.Length];



        //    int[] Aint = num1.Concat(num2).ToArray();

            // convert array
            for (int i = 0; i < num1.Length; i++)
            {

                Aint[i] = num1[i] ;    

                

            }

     

           for (int i = num1.Length; i < Aint.Length; i++)
            {
                for (int j = 0; j < num2.Length;j++)
                {

                    Aint[i] = num2[j];
                    i++;
                }

                break;
            }


           //
            //  Array.Sort(Aint);

           //sort array
            bool s;

            do
            {
                s= false;

                for (int i = 0; i < Aint.Length - 1; i++)
                {
                    if (Aint[i] > Aint[i + 1])
                    {
                        int temp = Aint[i];
                        Aint[i] = Aint[i + 1];
                        Aint[i + 1] = temp;
                        s = true;
                    }
                }
            } while (s);

          


            //

            if (Aint.Length % 2 != 0)
            {



                m = (Aint.Length + 1) / 2;

                result = Aint[m - 1];



            }
            else
            {


                m = Aint.Length / 2;

                m1 = (Aint.Length / 2) + 1;

                result = (Aint[m - 1] + Aint[m1 - 1]) / 2.0;


                //}



                // Console.WriteLine(result);
                Console.ReadKey();




        }
    }
}
