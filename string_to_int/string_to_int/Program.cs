using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace string_to_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "6";

           int  v = 0;


            if (s[0] == '-')
            {

                for (int i = 1; i < s.Length-1; i++)
                {



                    v += s[i];

                }


                v = v * -1;

            } else  
                
                for (int i = 0; i < s.Length; i++)
            
                {


               
                    v += s[i];

                }

            


              
            Console.Write(v);
            
            Console.ReadKey();

        }
    }
}
