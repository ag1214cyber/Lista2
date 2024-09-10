/*-------------------------------------------------------------------
Questão 2: Informações do Personagem
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
        int inimigos, tempoBatalha, pontos = 0, escolha;
        const int limite = 100;
        bool tomouCrit = false;

        Console.Write("Quantos inimigos foram derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigos);

        Console.Write("Quantos minutos a batalha durou: ");
        int.TryParse(Console.ReadLine(), out tempoBatalha);

        if (tempoBatalha > 5) {
            pontos -= 10;
        }

        Console.Write("O player sofreu dano crítico?\n1-Sim   2-Não ");
        int.TryParse(Console.ReadLine(), out escolha);

        switch (escolha) {
            case 1:
                tomouCrit = true;
            break;

            case 2:
                tomouCrit = false;
            break;
        }

        if (tomouCrit == true) {
            pontos =- 10;
        }

        pontos = inimigos * 10 + pontos;

        if (pontos > limite) {
            pontos = limite;
        }

        Console.Clear();
        Console.WriteLine($"A quantidade de pontos é de: {pontos}");

        System.Console.WriteLine("aperte enter para fechar: ");
        Console.ReadLine();
    }
}
