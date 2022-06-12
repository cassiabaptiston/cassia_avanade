using System;

namespace exercicio1
{

    class Program
    {

        public static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Console.WriteLine("Digite o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Agora digite a idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("Digite o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Agora digite a idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            Pessoa pessoa3 = new Pessoa();
            Console.WriteLine("Digite o nome da terceira pessoa: ");
            pessoa3.nome = Console.ReadLine();
            Console.WriteLine("Agora digite a idade: ");
            pessoa3.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade && pessoa1.idade > pessoa3.idade)
            {
                pessoa1.ExibirDados();
            }
            else if (pessoa2.idade > pessoa1.idade && pessoa2.idade > pessoa3.idade)
            {
                pessoa2.ExibirDados();
            }
            else if (pessoa3.idade > pessoa2.idade && pessoa3.idade > pessoa1.idade)
            {
                pessoa3.ExibirDados();
            }

        }

        static void animais()
        {
            Console.WriteLine("Digite o nome do animal. Se vazio o animal será peixe");
            string animal = Console.ReadLine().ToLower();
            if (animal == "cachorro")
            {

            }
        }


    }
}



