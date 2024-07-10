using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompletaWindowsForms.Models
{
    public class CalculadoraM
    {
        public decimal Dividir(decimal num1, decimal num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            return num1 / num2;
        }

        public decimal Multiplicar(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public decimal Somar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Subtrair(decimal num1, decimal num2)
        {
            return num1 - num2;
        }


    }
}
