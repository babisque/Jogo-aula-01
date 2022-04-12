using System;

namespace Aula1___Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sorteio = new Random().Next(1, 5);
            Console.WriteLine("Tente adivinhar o número entre 1 e 5:");
            int tentativa = 0;
            while (tentativa != sorteio)
            {
                tentativa = int.Parse(Console.ReadLine());
                if (tentativa == sorteio)
                {
                    break;
                }

                Console.WriteLine("Você errou. Deseja tentar novamente? (S/n) ");
                string tentar = Console.ReadLine();

                if (tentar == "n")
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine("Digite outra tentativa: ");
            }

            Console.WriteLine($"Você acertou!!! O número correto é {sorteio}");
        }
    }
}
