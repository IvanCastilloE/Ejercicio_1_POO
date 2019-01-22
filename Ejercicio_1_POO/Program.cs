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
            //Nuevo objeto misma clase. Este divide
            Calculadora calculadora2 = new Calculadora();
            calculadora2.Variable1 = 69;
            calculadora2.Variable2 = 54;
            calculadora2.Divicion();
            calculadora2.Mostrar();
            //Este multiplica
            Calculadora calculadora3 = new Calculadora();
            calculadora3.Variable1 = 7;
            calculadora3.Variable2 = 5;
            calculadora3.Divicion();
            calculadora3.Mostrar();

            Console.ReadLine();
        }
    }
}
