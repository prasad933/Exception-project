using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exception3
    {

        
        static void Main()
        {
            // when we are doing div both no should be positive - ApplicationException
            // divide no (b) should be even no  - by creating a new exception class

            int c = 0;
            try
            {
                Console.WriteLine("Enter a value : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value : ");
                int b = Convert.ToInt32(Console.ReadLine());
                if(a<0 || b < 0)// if you, error are one time then do ApplicationException 
                {
                    throw new ApplicationException("Both a and b values should be positive");//user defined Application exception
                }
                if(b%2 != 0)// in your application so many have to do then goes to ,like this approch create separate exception handle
                {
                    throw new OddnumberException();
                }
                c = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception {ex.Message}");
            }
            finally 
            { 
                Console.WriteLine($"Result is : " + c);
            }
            Console.ReadLine();
        }
    }
}
