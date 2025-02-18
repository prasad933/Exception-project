using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exception4
    {
        static void Main(string[] args)
        {
            int c = 0;
            try// try will throw an instance of that error
            {
                Console.WriteLine("Enter a value :");
                int a = Convert.ToInt32(Console.ReadLine());//55555555555555555 new OverflowException
                Console.WriteLine("Enter b value :");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a < 0 || b < 0) //in genral its not error negative numbers like ,it is ours definig so 
                {
                    throw new ApplicationException("Both nos should be positive");//user defined exception

                }
                c = checked( a * b);// when do the formulas and all like Arthimatic operations put it in checked
                                    //  because if any overflow exception raised that is checked and handled by the Exception class.

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Result : " + c );
            }
            Console.ReadLine();

        }
    }
}
