using System;

class Program
{
    static void Main()
    {
        int[] gabarito = new int[5];
        int[] aposta = new int[10];
        int pontos = 0;

        Console.WriteLine("Digite os números do gabarito da LOTO (5 números): ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Gabarito {i + 1}: ");
            gabarito[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Digite os números da sua aposta (10 números): ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Aposta {i + 1}: ");
            aposta[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (gabarito[i] == aposta[j])
                {
                    pontos++;
                }
            }
        }

        Console.WriteLine($"O apostador fez {pontos} pontos.");
    }
}
