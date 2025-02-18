using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exception2
    {
        static void Main(string[] args)
        {
            // when we are doing div both no should be positive - ApplicationException
            // divide no (b) should be even no  - by creating a new exception class

            int c = 0;
            try// try will throw an instance of that error
            {
                Console.WriteLine("Enter a value :");
                int a = Convert.ToInt32(Console.ReadLine());//55555555555555555 new OverflowException
                Console.WriteLine("Enter b value :");
                int b = Convert.ToInt32(Console.ReadLine());
                if(a<0 || b < 0) //in genral its not error negative numbers like ,it is ours definig so 
                {
                    throw new ApplicationException("Both nos should be positive");//user defined exception
                    
                }
                c = a / b;
            }
            //catch (DivideByZeroException ex)  
            //{
            //    Console.Write(ex.Message);
            //}
            catch (Exception ex)// check here with that instance related class--(Exception ex=new OverflowException) if it is there it can 
            {
                Console.Write(ex.Message);//here we are calling OverflowException Massage property massage
            }
            finally 
            {
                Console.WriteLine("Result is : " + c);

            }

        
            Console.ReadLine();
        }
    }
}
