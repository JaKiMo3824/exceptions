using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1) Create a list of integers. ask the user for a number to divide each number in the list by.  write a loop that takes each integer in the list, divides it by the number the user entered and displays the result to the screen

            List<double> intList = new List<double>();
            intList.Add(60.0);
            intList.Add(79.0);
            intList.Add(89.0);
            intList.Add(129.0);
            intList.Add(149.0);
            intList.Add(21.0);
            intList.Add(16.0);
            intList.Add(54.0);

            Console.WriteLine("Please enter a number..");
            double userInput = Convert.ToDouble(Console.ReadLine());

            foreach (double number in intList)
            {
                Console.WriteLine(number / userInput);
            }


            Console.ReadLine();
            
            //2) run that code entering in non-zero numbers as the user. look at the displayed results.
            //-changed int to double to get the decimal points otherwise it just rounded down

            //3) run that code, entering in zero as the number to divide by. note any error essages you get
            //-this returns the symbol for infinity without an error message-- but if i change the double back to int then i get an error message.


            //4) run that code entering in a string as the number to divide by. note any error messages you get.
            //-received a format error

            //5) now put the loop in a try catch block. below and outside of the try catch block, make the program display a message to the display to let you know the program has emerged from the try catch block and continued on with program execution in the catch block, display the error message to the screen.  then try various combinations of user input: valid numbers, zero and a string. ensure the proper error messages display on the screen, and that the code after the try catch block gets executed
            //changed double back to int so that the error message would pop up


            List<int> intList = new List<int>();
            intList.Add(60);
            intList.Add(79);
            intList.Add(89);
            intList.Add(129);
            intList.Add(149);
            intList.Add(21);
            intList.Add(16);
            intList.Add(54);

            
            try
            {
                Console.WriteLine("Please enter a number..");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int number in intList)
                {
                    Console.WriteLine(number / userInput);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number...");
                return;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            




















        }



    }
}
