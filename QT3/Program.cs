/*-------------------------------------------------------------------
Questão 3: Informações do Personagem
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
         Console.WriteLine("Classe do jogador:\n1 - Guerreiro\n2 - Mago\n3 - Paladino");
        int classe = ObterNumero("Escolha a classe (1, 2 ou 3):");

        Console.WriteLine("Tipo de poção:\n1 - Vida\n2 - Mana\n3 - Resistência");
        int tipoPocao = ObterNumero("Escolha o tipo de poção (1, 2 ou 3):");

        int quantidade = ObterNumero("Digite a quantidade de poções:");

        double precoPocao = ObterPrecoPocao(tipoPocao);
        double desconto = ObterDesconto(classe, tipoPocao);
        
        double precoTotal = precoPocao * quantidade;
        double precoComDesconto = precoTotal * desconto;

        Console.Clear();
        Console.WriteLine($"Preço total das poções: {precoTotal:C}");
        if (desconto < 1.0)
        {
            Console.WriteLine($"Preço com desconto: {precoComDesconto:C}");
        }
        else
        {
            Console.WriteLine("Nenhum desconto aplicável.");
        }

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }

    static int ObterNumero(string mensagem)
    {
        int numero;
        while (true)
        {
            Console.Write(mensagem);
            if (int.TryParse(Console.ReadLine(), out numero) && numero >= 1)
            {
                return numero;
            }
            Console.WriteLine("Entrada inválida. Tente novamente.");
        }
    }

    static double ObterPrecoPocao(int tipoPocao)
    {
        switch (tipoPocao)
        {
            case 1: return 10;
            case 2: return 15;
            case 3: return 20;
            default: throw new ArgumentException("Tipo de poção inválido.");
        }
    }

    static double ObterDesconto(int classe, int tipoPocao)
    {
        switch (classe)
        {
            case 1:
                if (tipoPocao == 1)
                    return 0.9;
                break;
            case 2:
                if (tipoPocao == 2)
                    return 0.85;
                break;
            case 3:
                if (tipoPocao == 3)
                    return 0.8;
                break;
        }
        return 1.0;
    }
}
