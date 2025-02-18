using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            prasad:
            int c=0;

            try
            {
                Console.WriteLine("Enter a value :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value :");
                int b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
            }
            catch (DivideByZeroException ex) //like DivideByZeroException,outrange like so many Exception classes having base class is (Exception it contains method ,properties,constructors)
            {
                Console.Write(ex.Message );//(ex.Message) this is get property from the Exception class
                goto prasad;
            }
            catch (Exception ex)// 
            {
                Console.Write(ex.Message);
            }
            finally //wether issue there or not there finally code block is excute
            {
                //if issue is there
                //try -catch-finally
                //if issue is not there
                //try -finally

                Console.WriteLine("Result is : " + c );
            }
            Console.ReadLine();
        }  
    }
}
