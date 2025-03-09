using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do salário por hora: R$ ");
        double salarioPorHora = Convert.ToDouble(Console.ReadLine());

        double salarioTotal;
        double horasExtras = 0;

        if (horasTrabalhadas > 160)
        {
            horasExtras = horasTrabalhadas - 160;
            salarioTotal = (160 * salarioPorHora) + (horasExtras * salarioPorHora * 1.50);
        }
        else
        {
            salarioTotal = horasTrabalhadas * salarioPorHora;
        }

        Console.WriteLine($"O salário total do funcionário é: R$ {salarioTotal:F2}");
    }
}
