using System;
using System.Collections.Generic;
public class ExemploList
{
    public static void Main(string[] args)
    {
        // Criando uma lista de strings
        List<string> frutas = new List<string>();
        // Adicionando itens
        frutas.Add("Maçã");
        frutas.Add("Banana");
        frutas.Add("Laranja");
        frutas.Add("Maçã"); // Duplicatas são permitidas
        Console.WriteLine($"Número de frutas: {frutas.Count}"); //Output: 4
        // Acessando por índice
        Console.WriteLine($"Primeira fruta: {frutas[0]}"); // Output: Maçã
        // Iterando sobre a lista
        Console.WriteLine("\nFrutas na lista:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine($"- {fruta}");
        }
        // Removendo um item
        frutas.Remove("Banana");
        Console.WriteLine($"\nApós remover Banana, {frutas.Count} frutas restantes.");
        // Verificando se contém
        Console.WriteLine($"Contém Laranja?{ frutas.Contains("Laranja")}"); // Output: True
    }
}
