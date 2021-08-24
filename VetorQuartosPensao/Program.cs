using System;

namespace VetorQuartosPensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] vet = new Estudantes[10];

            Console.WriteLine("Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int num = int.Parse(Console.ReadLine());
                vet[num] = new Estudantes(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}
