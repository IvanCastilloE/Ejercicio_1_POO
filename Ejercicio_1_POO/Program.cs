using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Variable1 = 420;
            calculadora.Variable2 = 911;
            //Mostrar datos asignados a variables de constructor calculadora
            calculadora.Mostrar();
            //Se suman las variables
            calculadora.Suma();
            calculadora.Mostrar();
            //Nuevo objeto misma clase
            Calculadora calculadora2 = new Calculadora();
            calculadora2.Variable1 = 69;
            calculadora2.Variable2 = 54154;
            calculadora2.Suma();
            calculadora2.Mostrar();

            Console.ReadLine();
        }
    }
}
