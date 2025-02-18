using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exception5
    {
        static void Division(int a,int b)
        {
            try// inner try block checks the exception 
            {
                int c = a / b;
            }
            catch (FormatException ex)//if there is no related catch block here then checks in Main like below
            {                         //here there is no divide by zero so it will check in main method 
                                      //so if you for to give base exception here give in main method
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("Enter any 2 No's ");
                int a = Convert.ToInt32(Console.ReadKey());
                int b = Convert.ToInt32(Console.ReadKey());

                int c = checked(a * b);
                Console.WriteLine("Result :" + c);
                Division(a, b);
            }
            catch(Exception ex) //base class 
            {
                Console.WriteLine($"Exception {ex.Message}");
            }
        }

    }
}
