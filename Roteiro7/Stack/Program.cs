using System;
using System.Collections.Generic;
public class ExemploStack
{
    public static void Main(string[] args)
    {
        // Criando uma pilha para histórico de navegação
        Stack<string> historicoPaginas = new Stack<string>();
        // Navegando (Push)
        historicoPaginas.Push("google.com");
        historicoPaginas.Push("docs.microsoft.com");
        historicoPaginas.Push("github.com");
        Console.WriteLine($"Número de páginas no histórico: { historicoPaginas.Count}"); // Output: 3
        // Ver a última página acessada (Peek)
        Console.WriteLine($"Última página: {historicoPaginas.Peek()}");
        // Output: github.com
        // Voltando (Pop)
        Console.WriteLine("\nApertando 'Voltar':");
        while (historicoPaginas.Count > 0)
        {
            string paginaAnterior = historicoPaginas.Pop();
            Console.WriteLine($"- Voltando de: {paginaAnterior}");
        }
        Console.WriteLine($"\nItens restantes no histórico: { historicoPaginas.Count}"); // Output: 0
    }
}