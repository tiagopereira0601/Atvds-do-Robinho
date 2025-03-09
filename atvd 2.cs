using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a altura da pessoa (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o sexo da pessoa (M para masculino ou F para feminino): ");
        char sexo = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        double pesoIdeal;

        if (sexo == 'M')
        {
            pesoIdeal = (72.7 * altura) - 58;
            Console.WriteLine($"O peso ideal para um homem de {altura}m é: {pesoIdeal:F2} kg");
        }
        else if (sexo == 'F')
        {
            pesoIdeal = (62.1 * altura) - 44.7;
            Console.WriteLine($"O peso ideal para uma mulher de {altura}m é: {pesoIdeal:F2} kg");
        }
        else
        {
            Console.WriteLine("Sexo inválido! Por favor, digite 'M' para masculino ou 'F' para feminino.");
        }
    }
}
