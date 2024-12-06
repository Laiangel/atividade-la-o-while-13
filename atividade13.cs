using System;

class Program
{
    static void Main(string[] args)
    {
        int somaPares = 0; // Variável para armazenar a soma dos números pares

        Console.WriteLine("Digite números inteiros. Digite 0 para encerrar e ver a soma dos números pares.");

        while (true)
        {
            Console.Write("Digite um número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero == 0)
                {
                    // Encerra o programa ao digitar 0
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                // Verifica se o número é par e adiciona à soma
                if (numero % 2 == 0)
                {
                    somaPares += numero;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
        }

        // Exibe o resultado da soma
        Console.WriteLine($"\nA soma dos números pares digitados é: {somaPares}");
    }
}
