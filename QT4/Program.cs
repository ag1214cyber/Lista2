/*-------------------------------------------------------------------
Questão 4: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.
@Lista: 02 - Lógica de Programação
@Autor: Arthur Gabriel
@Data: 09/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main()
    {
        int mana = ObterValor("Digite a quantidade de mana que você tem atualmente: ");
        double vidaInimigo = ObterValorDecimal("Digite a vida do inimigo em porcentagem (0 a 100): ");
        int nivel = ObterValor("Digite o seu nível atual: ");

        if (mana > 30 && vidaInimigo < 50 && nivel > 5)
        {
            Console.WriteLine("Ataque Especial Realizado");
        }
        else
        {
            if (mana <= 30)
                Console.WriteLine("Mana Insuficiente");
            else if (vidaInimigo >= 50)
                Console.WriteLine("Vida do inimigo muito alta");
            else if (nivel <= 5)
                Console.WriteLine("Nível Insuficiente");
        }

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }

    static int ObterValor(string mensagem)
    {
        int valor;
        Console.Write(mensagem);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
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
            Console.WriteLine("Entrada inválida. Por favor, insira um valor decimal entre 0 e 100.");
            Console.Write(mensagem);
        }
        return valor;

    }
}
