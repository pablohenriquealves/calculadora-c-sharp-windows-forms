using CalculadoraCompletaWindowsForms.Models;
using System.Runtime.CompilerServices;

namespace CalculadoraCompletaWindowsForms.Tests
{
    public class CalculadoraCompletaWindowsFormsTests
    {
        private readonly CalculadoraM _calc = new CalculadoraM();

        [Fact]
        public void Somar_DeveRetornar15_Quando5Mais10()
        {

            decimal resultadoEsperado = 15;
            decimal result = _calc.Somar(5, 10);
            Assert.Equal(resultadoEsperado, result);
            
        }       
        
        [Fact]
        public void Subtrair_DeveRetornar20_Quando30Menos10()
        {

            decimal resultadoEsperado = 20;
            decimal result = _calc.Subtrair(30, 10);
            Assert.Equal(resultadoEsperado, result);
            
        }        
        
        [Fact]
        public void Multiplicar_DeveRetornar25_Quando5Por5()
        {

            decimal resultadoEsperado = 25;
            decimal result = _calc.Multiplicar(5, 5);
            Assert.Equal(resultadoEsperado, result);
            
        }
        [Fact]
        public void Dividir_DeveRetornar20_Quando100Por5()
        {

            decimal resultadoEsperado = 20;
            decimal result = _calc.Dividir(100, 5);
            Assert.Equal(resultadoEsperado, result);

        }

        [Fact]
        public void Dividir_DeveLancarDivideByZeroException_QuandoDivisorForZero()
        {

            var ex = Assert.Throws<DivideByZeroException>(()=> _calc.Dividir(10, 0));   
            Assert.Equal("Não é possível dividir por zero.", ex.Message);

        }
    }
}