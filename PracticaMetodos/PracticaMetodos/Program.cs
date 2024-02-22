using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodos
{
    internal class Program
    {
        //int numero1 = 5;
        //int numero2 = 7;
        static void Main(string[] args)
        {
            //mensajePantalla();
            //Console.WriteLine(" Mensaje desde el metodo Main");
            //sumaNumeros(7, 8);
            //Console.WriteLine(sumaNumeros (7, 5));
            //Console.WriteLine(divideNUmeros(7, 5));

            //LAMAR SOBRECARGAS DE METODOS 
            Console.WriteLine(Suma(7,5.2 ));


        }
        //SOBRECARGA DE METODOS
        static int Suma (int operador1,  int operador2)=>operador1 + operador2;

        static int Suma(int numero1, double numero2 )=> numero1;

        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;



        //void primerMetodo()
        //{
        //    Console.WriteLine(numero1+numero2);

        //}
        //void segundoMetodo()
        //{
        //    Console.WriteLine(numero1+numero2);
        //}

        //static void mensajePantalla()
        //{
        //    Console.WriteLine("Mensaje desde el metodo mensaje en pantalla");
        //}

        //static void sumaNumeros(int num1, int num2)
        //{
        //   Console.WriteLine($"La suma de los numeros es : {num1+num2}");
        //}

        //  static int sumaNumeros(int num1, int num2)
        //{
        //    return num1 + num2 ;
        //}


        //static double divideNUmeros(double num1, int num2)
        //{
        //    return num1 / num2;
        //}

        //static double divideNUmeros(double num1, int num2) => num1 / num2; //ESTA FORMA ES MAS CORTA CUANDO HAY 1 LINEA
    }
}
