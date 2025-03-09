using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a venda média mensal: ");
        double vendaMedia = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o preço atual do produto: R$ ");
        double precoAtual = Convert.ToDouble(Console.ReadLine());
        
        double precoReajustado = precoAtual;
        
        if (vendaMedia < 500 && precoAtual < 30.00)
        {
            precoReajustado = precoAtual * 1.10;
            Console.WriteLine("O preço do produto será aumentado em 10%.");
        }
        else if (vendaMedia >= 500 && precoAtual >= 30.00)
        {
            precoReajustado = precoAtual * 0.80;
            Console.WriteLine("O preço do produto será reduzido em 20%.");
        }
        else
        {
            Console.WriteLine("Não haverá alteração no preço do produto.");
        }
        
        Console.WriteLine($"O preço reajustado do produto é: R$ {precoReajustado:F2}");
    }
}

