/*
1. Permita adicionar nomes de clientes à fila.
2. Permita "atender" o próximo cliente (removendo-o do início da fila e exibindo seu
nome).
3. Mostre quantos clientes ainda estão na fila. Dica: Use um menu simples para
adicionar cliente, atender próximo, ver tamanho ou sair. 
*/

class Program
{
    static void Main()
    {
        Queue<string> Clientes = new Queue<string>();
        bool verif = true;
        while (verif)
        {
            Console.WriteLine("Digite uma opção:\n1 - Adicionar\n2 - Atender\n3 - Tamanho\n4 - Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do cliente: ");
                    string nome = Console.ReadLine();
                    Clientes.Enqueue(nome);
                    break;
                case 2:
                    Console.WriteLine(Clientes.Peek());
                    Clientes.Dequeue();
                    break;
                case 3:
                    Console.WriteLine($"Tamanho da fila: {Clientes.Count()}");
                    break;
                case 4:
                    verif = false;
                    break;
            }
        }
    }
}