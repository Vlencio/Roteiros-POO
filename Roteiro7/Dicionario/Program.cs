using System;
using System.Collections.Generic;
using System.Text;
public class ExemploDictionary
{
    public static void Main(string[] args)
    {
        // Criando um dicionário (ID -> Nome)
        Dictionary<int, string> alunos = new Dictionary<int, string>();
        // Adicionando itens
        alunos.Add(101, "Ana");
        alunos.Add(205, "Bruno");
        alunos[317] = "Carlos"; // Outra forma de adicionar/atualizar
        Console.WriteLine($"Número de alunos: {alunos.Count}"); //Output: 3
        // Acessando por chave
        Console.WriteLine($"Aluno com ID 205: {alunos[205]}"); //Output: Bruno
        // Verificando existência e acessando com segurança
        int idBusca = 317;
        if (alunos.ContainsKey(idBusca))
        {
            Console.WriteLine($"Aluno com ID {idBusca}:{ alunos[idBusca]}"); // Output: Carlos
        }
        // Iterando sobre o dicionário (pares KeyValuePair)
        Console.WriteLine("\nAlunos no dicionário:");
        foreach (KeyValuePair<int, string> par in alunos)
        {
            Console.WriteLine($"- ID: {par.Key}, Nome: {par.Value}");
        }
        // Removendo
        alunos.Remove(101);
        Console.WriteLine($"\nApós remover ID 101, {alunos.Count} alunosrestantes.");
    }
}