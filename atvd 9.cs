using System;

class Program
{
    static void Main()
    {
        double[] notas = new double[6];
        double maiorNota, menorNota, somaNotas = 0;

        Console.WriteLine("Digite as notas dos 6 juízes (entre 0 e 10):");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Nota do juiz {i + 1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }

        maiorNota = notas[0];
        menorNota = notas[0];

        for (int i = 1; i < 6; i++)
        {
            if (notas[i] > maiorNota)
            {
                maiorNota = notas[i];
            }

            if (notas[i] < menorNota)
            {
                menorNota = notas[i];
            }
        }

        foreach (double nota in notas)
        {
            if (nota != maiorNota && nota != menorNota)
            {
                somaNotas += nota;
            }
        }

        Console.WriteLine($"A nota final do atleta é: {somaNotas:F2}");
    }
}
