using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideTwoIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend = -2147483648;
            int divisor = -1;
            int cpt = 0;
             
           

            if (divisor < 0 && dividend > 0) { divisor = divisor * -1; for (int i = 0; i < dividend; i++) { dividend -= divisor; cpt++; } cpt *= -1; }

            else if(dividend > 0 && divisor > 0 && divisor > dividend) 
            
            { cpt = 0;  }


            else if (dividend < 0 && divisor < 0 ) 
            
               
            
            { .divisor = Convert.ToInt64(divisor) * -1; dividend = dividend * -1; ;
                for (int i = 0; i < dividend; i++) 
  
                { dividend -= divisor; 
                    
                    
                    cpt++; }  
            
            }
            else if(dividend < 0 && divisor > 0) 
            { dividend = dividend * -1; for (int i = 0; i < dividend; i++) 
                { dividend -= divisor; cpt++; } cpt *= -1; }

            else for (int i = 0; i < dividend;   i++)
                
                
                { dividend -= divisor;  cpt++; } 
           

            
            int q = dividend * divisor;


            Console.WriteLine(cpt);
            Console.ReadKey();

        }
    }
}
