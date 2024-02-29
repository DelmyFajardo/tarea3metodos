using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class program 
    
    {
         public static void Main(string[] args)
        {
         
       
            Console.Write(" Acontinuacion se calculara  tu salario de los ultimos tres meses por lo que debes ingresar los datos que se te piden   ");
            Console.Write("Escribe tu nombre: ");
            string  nombre = Console.ReadLine();

            Console.Write("Ingresa tu antepenultimo  salario  : ");
            string mesante = Console.ReadLine();
            int dato1 = int.Parse(mesante);


            
            Console.Write("Ingresa tu penultimo salario : ");
            string mespenultimo = Console.ReadLine();
            int dato2 = int.Parse(mespenultimo);

            Console.Write("Ingresa tu ultimo salario: ");
            string mesultimo = Console.ReadLine();
            int dato3 = int.Parse(mespenultimo);

            int suma = dato1 + dato2 + dato3 ;
            int promedio = suma / 3;

            Console.Write("Buen dia " + nombre);
            Console.ReadLine();
            Console.Write("  tu suma total de ingresos es:" + suma);
            Console.ReadLine();
            Console.Write("Y tu pormedio total es:" + promedio);
            Console.ReadLine();
                }
    }
}
