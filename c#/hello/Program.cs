// See https://aka.ms/new-console-template for more information
using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.escrever();
            //   Program.escreverString("xxxxx");
            Program.soma(4, 5);
            Program.escreveODigitado();
        }

        static void escrever()
        {
            Console.WriteLine("Hello World!");
            string nome = "Cassia";
            int idade = 32;
            double altura = 1.61;
            bool casado = true;
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(casado);
        }

        // static void escreverString(string s)

        //{
        //    Console.WriteLine(s);
        //}
        //  Escrever uma função que some 2 números passados como parâmetro e imprima na tela. use a função no método Program e use o dotnet run pra ver o resultado no console.




        static void soma(int a, int b)
        {
            int soma = a + b;
            Console.WriteLine(soma);
        }
        static void escreveODigitado()
        {
            Console.WriteLine("Digite um número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número");
            int n2 = int.Parse(Console.ReadLine());
            int produto = n1*n2;
            Console.WriteLine("Digite um número para somar ao produto da multiplicação anterior");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu resultado é " + (produto + n3));

            //1 - mudar a função soma para retornar o resultado.
            //2 - receber do usuário os valores a serem somados
            //3 - criar uma outra função com nome do tipo escreveSoma que chame a soma e imprima na tela

        }

    }
}

