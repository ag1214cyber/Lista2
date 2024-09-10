/*-------------------------------------------------------------------
Questão 5: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.
@Lista: 02 - Lógica de Programação
@Autor: Arthur Gabriel
@Data: 10/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main()
    {
        double vida = ObterValorDecimal("Digite a vida do personagem (0 a 100)");
        int armadilhas = ObterValorInteiro("Digite a quantidade de armadilhas conhecidas");
        int distancia = ObterValorInteiro("Digite a distância do aliado");

        if (vida > 50 && armadilhas < 3)
        {
            Console.WriteLine("Seguir em frente");
        }
        else if (vida < 50 && armadilhas < 2 && distancia < 10)
        {
            Console.WriteLine("Tentar resgate rápido");
        }
        else
        {
            Console.WriteLine("RECUAR");
        }

        Console.WriteLine("\nPressione enter para fechar");
        Console.ReadLine();
    }

    static int ObterValorInteiro(string mensagem)
    {
        int valor;
        Console.Write(mensagem);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Insira um número inteiro.");
            Console.Write(mensagem);
        }
        return valor;
    }

    static double ObterValorDecimal(string mensagem)
    {
        double valor;
        Console.Write(mensagem);
        while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0 || valor > 100)
        {
            Console.WriteLine("Entrada inválida. Insira um valor decimal entre 0 e 100.");
            Console.Write(mensagem);
        }
        return valor;

    }
}