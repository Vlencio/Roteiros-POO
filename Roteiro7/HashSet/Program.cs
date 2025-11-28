using System;
using System.Collections.Generic;
public class ExemploHashSet
{
    public static void Main(string[] args)
    {
        // Criando um HashSet de números inteiros
        HashSet<int> numerosUnicos = new HashSet<int>();
        // Adicionando itens
        numerosUnicos.Add(5);
        numerosUnicos.Add(10);
        numerosUnicos.Add(5); // Tentativa de adicionar duplicata (será ignorada)numerosUnicos.Add(20);
        Console.WriteLine($"Número de itens únicos:{ numerosUnicos.Count}"); // Output: 3
        // Verificando existência (muito rápido!)
        Console.WriteLine($"Contém o número 10? { numerosUnicos.Contains(10)}"); // Output: True
        Console.WriteLine($"Contém o número 15? { numerosUnicos.Contains(15)}"); // Output: False
        // Iterando (ordem não garantida)
        Console.WriteLine("\nNúmeros no conjunto:");
        foreach (int numero in numerosUnicos)
        {
            Console.WriteLine($"- {numero}");
        }
        // Removendo
        numerosUnicos.Remove(10);
        Console.WriteLine($"\nApós remover 10, contém 10? { numerosUnicos.Contains(10)}"); // Output: False
}
}