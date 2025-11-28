using System;
using System.Collections.Generic;
public class ExemploQueue
{
    public static void Main(string[] args)
    {
        // Criando uma fila de tarefas
        Queue<string> filaTarefas = new Queue<string>();
        // Adicionando tarefas (Enqueue)
        filaTarefas.Enqueue("Lavar louça");
        filaTarefas.Enqueue("Pagar contas");
        filaTarefas.Enqueue("Estudar C#");
        Console.WriteLine($"Número de tarefas na fila: { filaTarefas.Count}"); // Output: 3
        // Ver a próxima tarefa sem remover (Peek)
        Console.WriteLine($"Próxima tarefa: {filaTarefas.Peek()}"); //Output: Lavar louça
        // Processando tarefas (Dequeue)
        Console.WriteLine("\nProcessando tarefas:");
        while (filaTarefas.Count > 0)
        {
            string tarefaAtual = filaTarefas.Dequeue();
            Console.WriteLine($"- Processando: {tarefaAtual}");
        }
        Console.WriteLine($"\nTarefas restantes: {filaTarefas.Count}");
        // Output: 0
    }
}