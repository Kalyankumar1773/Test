using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Class1
    {
        public  void Main()
        {
            int i= 5;
            int reslt = Factorial(i);
            Console.WriteLine("sreslt = " +reslt);
        }


        private int Factorial(int test)
        {
            int reslt=1;
            for(int i =test; i >=1; i--)
            {               
                for(int star=1; star <=i; star++)
                {
                    Console.WriteLine("*");
                }
                reslt = reslt * i;
                Console.WriteLine(reslt);
            }
            return reslt;
        }
    }
}
