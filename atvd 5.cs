using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Responda as perguntas abaixo com 'Sim' ou 'Não'.");

        Console.Write("O animal é mamífero? ");
        string resposta = Console.ReadLine().ToLower();

        if (resposta == "sim")
        {
            Console.Write("O animal é quadrúpede? ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.Write("O animal é carnívoro? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.WriteLine("O animal escolhido foi o leão.");
                }
                else
                {
                    Console.Write("O animal é herbívoro? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o cavalo.");
                    }
                    else
                    {
                        Console.WriteLine("Animal não identificado.");
                    }
                }
            }
            else
            {
                Console.Write("O animal voa? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.Write("O animal é um morcego? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o morcego.");
                    }
                    else
                    {
                        Console.Write("O animal é uma baleia? ");
                        resposta = Console.ReadLine().ToLower();

                        if (resposta == "sim")
                        {
                            Console.WriteLine("O animal escolhido foi a baleia.");
                        }
                        else
                        {
                            Console.WriteLine("Animal não identificado.");
                        }
                    }
                }
                else
                {
                    Console.Write("O animal é um macaco? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o macaco.");
                    }
                    else
                    {
                        Console.Write("O animal é um homem? ");
                        resposta = Console.ReadLine().ToLower();

                        if (resposta == "sim")
                        {
                            Console.WriteLine("O animal escolhido foi o homem.");
                        }
                        else
                        {
                            Console.WriteLine("Animal não identificado.");
                        }
                    }
                }
            }
        }
        else
        {
            Console.Write("O animal é um pássaro? ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.Write("O animal é uma águia? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.WriteLine("O animal escolhido foi a águia.");
                }
                else
                {
                    Console.Write("O animal é um pinguim? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o pinguim.");
                    }
                    else
                    {
                        Console.Write("O animal é um pato? ");
                        resposta = Console.ReadLine().ToLower();

                        if (resposta == "sim")
                        {
                            Console.WriteLine("O animal escolhido foi o pato.");
                        }
                        else
                        {
                            Console.Write("O animal é um avestruz? ");
                            resposta = Console.ReadLine().ToLower();

                            if (resposta == "sim")
                            {
                                Console.WriteLine("O animal escolhido foi o avestruz.");
                            }
                            else
                            {
                                Console.WriteLine("Animal não identificado.");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Animal não identificado.");
            }
        }
    }
}
