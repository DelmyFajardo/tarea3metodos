using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace desafio2
{
  class program 
    {
        public  static void Main(string[]args)
        {
            Console.WriteLine("Ingresa los datos que se te piden ");
            Console.WriteLine("ingresa  un numero: ");
            string dato = Console.ReadLine();
            int num1 =  int .Parse(dato);


            Console.WriteLine("Ingresa un numero: ");
            dato = Console.ReadLine() ;
            int num2 = int.Parse(dato);

            int resultado1 = sumar(num1, num2);
            int resultado2 = resta(num1, num2);
            int resultado3 = multiplicacion(num1, num2);
            int resultado4 = division(num1, num2);

            Console.WriteLine("La suma de los numeros ingresados es: " + resultado1);
            Console.ReadLine();
            Console.WriteLine("La resta de los numeros ingresados es: "+ resultado2);
            Console.ReadLine();
            Console.WriteLine("La multiplicacion  de los numeros ingresados es: "+ resultado3);
            Console.ReadLine();
            Console.WriteLine("La division  de los numeros ingresados es: "+ resultado4);
            Console.ReadLine();

        }
        static int sumar(int num1, int num2)
        {
            return num1 + num2;
            
        }


        static int resta (int num1, int num2 )
        {
            return num1 - num2;
        }

        static int multiplicacion (int num1, int num2)
        {
            return  num1 *  num2;
        }

        static int division (int num1, int num2)
        {
            return num1 / num2;
        }
    }
        
    
}
