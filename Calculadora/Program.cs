using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(""); //Não pula linha
            //Console.WriteLine("Hello World!"); //Pula linha
            //Console.Read();//Le
            //Console.ReadKey();//Le um item
            //Console.ReadLine();//Le uma linha

            Menu();
        }

        static void Menu() {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção");
            short resposta = short.Parse(Console.ReadLine());

            switch (resposta){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }



        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Soma");
            Console.WriteLine("Digite os valores");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            int valor2 = int.Parse(Console.ReadLine());

            int resultado = valor1 + valor2;
            //Console.WriteLine($"O valor da soma é {valor1 + valor2}");
            //Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"Resutado: {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Subtração");

            Console.WriteLine("Primeiro Valor");
            int primeiroValor = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            int segundoValor = int.Parse(Console.ReadLine());

            int resultado = primeiroValor - segundoValor;

            Console.WriteLine($"Resultado:" + resultado);
            Console.WriteLine($"Resultado: {primeiroValor - segundoValor}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Divisão");
            Console.WriteLine("Digite o primerio valor");

            float primeiroValor = float.Parse(Console.ReadLine());
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor / segundoValor;

            Console.WriteLine($"Resultado da divisão: {primeiroValor / segundoValor}");
            Console.WriteLine($"Resultado da divisão:{resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Multiplicacão");
            Console.WriteLine("Primeiro Valor");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado  = primeiroValor * segundoValor;
            Console.WriteLine($"Resultado:{primeiroValor * segundoValor}");
            Console.WriteLine($"Resultado:{resultado}");

            Console.ReadLine();
            Menu();
        }
    }
}
