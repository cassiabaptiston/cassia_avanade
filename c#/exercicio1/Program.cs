using System;

namespace exercicio1
{

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(Program.animais());
        }
        static void pessoas()

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

        static string animais()
        {
            int ContCachorros = 0;
            int ContGatos = 0;
            int ContPeixes = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome do animal. Se vazio o animal será peixe");
                string animal = Console.ReadLine().ToLower();
                if (animal == "cachorro")
                {
                    Cachorro cachorro = new Cachorro();
                    cachorro.especie = "Canis";
                    cachorro.reino = "Animal";
                    cachorro.Respirar();
                    ContCachorros++;
                }
                else if (animal == "gato")
                {
                    Gato gato = new Gato();
                    gato.especie = "Felis";
                    gato.reino = "Animal";
                    gato.Respirar();
                    ContGatos++;
                }
                else
                {
                    Peixe peixe = new Peixe();
                    peixe.especie = "Aquaticos";
                    peixe.reino = "Animal";
                    peixe.Respirar();
                    ContPeixes++;
                }
            }
            return "Foram " + ContCachorros + "cachorros, " + ContGatos + " gatos e " + ContPeixes + " peixes.";

        }
    }
}



