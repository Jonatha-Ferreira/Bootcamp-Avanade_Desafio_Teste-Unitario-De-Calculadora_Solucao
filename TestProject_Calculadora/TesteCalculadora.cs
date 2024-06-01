using ConsoleApp_Calculadora;

namespace TestProject_Calculadora
{
    public class TesteCalculadora
    {
   
        [Fact]
        public void Soma_1_Com_2_E_Retorna_3()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.somar(1, 2);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void Subtrai_1_Com_2_E_Retorna_1Negativo()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.subtrair(1, 2);

            Assert.Equal(-1, resultado);
        }

        [Fact]
        public void Multiplica_1_Com_2_E_Retorna_2()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.multiplicar(1, 2);

            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Divide_2_Com_2_E_Retorna_1()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.dividir(2, 2);

            Assert.Equal(1, resultado);
        }

    }
}