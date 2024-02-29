using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3
{
    internal class Program

    {


        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("**Instrucciones: debes de ingresar los datos que se te piden tomando en cuenta que no puedes dejar espacio en blanco  ");
                Console.WriteLine("ni ingresar texto unicamente numeros.  ");
                Console.WriteLine("suma de dos numeros");

                Console.Write("Ingresa el primer numero: ");
                string valor = Console.ReadLine();
                int numero1 = int.Parse(valor);



                Console.WriteLine("Ingresa el segundo numero: ");
                valor = Console.ReadLine();
                int numero2 = int.Parse(valor);

                int suma = numero1 + numero2;
                
           
         
                Console.WriteLine("La suma de los dos numeros ingresados es:{0}  ", suma);
                Console.ReadLine();
              
        }
           catch (Exception)
            {
                Console.WriteLine("vaya! algo salio mal, revisanlos datos que se te piden ");

            }

}   
        
    }
}
