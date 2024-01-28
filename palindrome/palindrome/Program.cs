using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool ispalindrome = false;
            int x = 000000000000000;

            string revresed = null;
            string notrevresed = null;


            string stringx = x.ToString(); 

            for (int i = 0; i < stringx.Length; i++) {


                revresed += stringx[i];   
             
              
            
            }

            
            for (int i = stringx.Length;  --i >= 0;)
            {

                notrevresed += stringx[i];

            }


            if (revresed == notrevresed)
            {

                ispalindrome = true;

            }
            else ispalindrome = false;










            Console.WriteLine(ispalindrome);
  

            
            
            
         
           
            Console.ReadKey();
        }
    }
}
