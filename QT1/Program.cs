/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
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
        Console.WriteLine("Escolha a sua classe (guerreiro, arqueiro, mago)");
        string? inputClasse = Console.ReadLine();
        if (string.IsNullOrEmpty(inputClasse))
        {
            Console.WriteLine("Classe invalida");
            return;
        }   
             string classe = inputClasse.Trim().ToLower();

        if (classe != "guerreiro" && classe != "arqueiro" && classe != "mago")
        {
            Console.WriteLine("Classe inválida. Por favor, insira uma classe válida (Guerreiro, Arqueiro, Mago).");
            return;
        }

        Console.WriteLine("Digite o valor de defesa da armadura:");
        if (!int.TryParse(Console.ReadLine(), out int defesa))
        {
            Console.WriteLine("Valor inválido para defesa. Por favor, insira um número inteiro.");
            return;
        }

        Console.WriteLine("Digite o valor da penalidade de agilidade:");
        if (!int.TryParse(Console.ReadLine(), out int penalidadeAgilidade))
        {
            Console.WriteLine("Valor inválido para penalidade de agilidade. Por favor, insira um número inteiro.");
            return;
        }

        bool armaduraAdequada = classe switch
        {
            "guerreiro" => defesa > 50 && penalidadeAgilidade < 20,
            "arqueiro" => defesa > 30 && penalidadeAgilidade < 10,
            "mago" => defesa > 20 && penalidadeAgilidade < 40,
            _ => false
        };

        Console.WriteLine(armaduraAdequada ? "Armadura adequada" : "Armadura não adequada");

        Console.WriteLine("Aperte enter para fechar: ");
        Console.ReadLine();

        
    }
}