using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 1534236469;

            string result = null;
            string resultn = "-";
            string finalresul = null;
            string s = Convert.ToString(x);
            int intresult = 0;




            try {
            


            if (s.Contains('-'))
            {


                for (int i = s.Length; --i >= 1;)
                {


                    resultn += s[i];


                }



            }
            else
            {


                for (int i = s.Length; --i >= 0;)
                {


                    result += s[i];


                }



            }


            if (resultn != "-") { finalresul = resultn; } else if (result != "") { finalresul = result; }





            intresult = Convert.ToInt32(finalresul);




            }catch (Exception e) { intresult = 0; }

            


           

            Console.WriteLine(intresult);

            Console.ReadKey();










        }
    }
}
