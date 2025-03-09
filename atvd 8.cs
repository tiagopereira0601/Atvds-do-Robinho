using System;

class Program
{
    static void Main()
    {
        int[] D = new int[20];
        int N;

        Console.WriteLine("Digite os 20 elementos do vetor D:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            D[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Digite o valor de N: ");
        N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Vetor compactado (elementos maiores que N):");

        for (int i = 0; i < 20; i++)
        {
            if (D[i] > N)
            {
                Console.Write(D[i] + " ");
            }
        }

        Console.WriteLine();
    }
}
