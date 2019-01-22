using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_POO
{
    class Calculadora
    {
        //Declaramos variables/datos
        public double Variable1;
        public double Variable2;
        public double Resultado;

        public void Suma()
        {
            //Operacion Suma
            Resultado = Variable1 + Variable2;

        } 
        public void Mostrar()
        {
            //Mostrar resultado
            Console.WriteLine("Variable1={0}, Variable2={1}, resultado={2}", Variable1, Variable2, Resultado); 
        }
    }

}
