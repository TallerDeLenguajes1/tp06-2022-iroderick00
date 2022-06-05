using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Calculadora
    {
        public double resultado;
        public void Sumar (double numero)
        {
            resultado += numero;
        }
        public void Restar (double numero)
        {
            resultado -= numero; 
        }
        public void Multiplicar (double numero)
        {
            resultado *= numero;
        }
        public void Dividir (double numero)
        {
            if (numero != 0)
            {
                resultado /= numero;
            }
            else
            {
                Console.WriteLine("No está definida la división por cero.");
            }
        }
        public void Clear()
        {
            resultado = 0;
        }
        public Calculadora (double numero)
        {
            resultado = numero;
        }
    }
}
