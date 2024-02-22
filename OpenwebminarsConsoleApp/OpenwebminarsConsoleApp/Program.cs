using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenwebminarsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////==
            ////!=
            //>=
            //>=
            //<
            //>

            //&& (AND)
            //|| (OR)

       

        }

       
        

        static void Declarations()
        {
            int number = 0;
            double numberDecimals = 0.0d;
            bool yayOrNay = true;
            string helloWorld = string.Empty;
        }

        static void Conditions ()
        {
            int number = 0;
            number += 2;
            // number => 2

            number -= 2;
            //number => 0;

            //SI
            if (number == 0)
            {
                //
            }
            //si no si
            else if (number > 0)
            {

            }
            else
            {

            }

        }
        static void Loops()
        {
            int number = 0;

            for (int i = 0; i < 10; i++)
            {
                // Do something
            }

            while (number != 10)
            {
                number++;
            }
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {

            }
        }

        static void Cases ()
        {
            int number = 0;
            switch (number)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
