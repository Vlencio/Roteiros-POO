/*
Exercício 1: Lista de Compras (List<T>) Crie um programa que permita ao usuário:
1. Adicionar itens a uma lista de compras.
2. Remover itens da lista.
3. Listar todos os itens na lista.
4. Mostrar a quantidade total de itens. Dica: Use um loop while e peça a ação do
usuário (adicionar, remover, listar, sair).
*/

class Program
{
    static void Main()
    {
        List<Compras> ListaCompras = new List<Compras>();
        Compras produto;
        bool verif = true;
        while (verif)
        {
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Adicionar:\n2 - Remover:\n3 - Listar todos\n4 - Finalizar");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do produto:");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a quantidade do produto:");
                    int quantidade = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor do produto:");
                    double valor = double.Parse(Console.ReadLine());
                    produto = new Compras(nome,quantidade,valor);
                    ListaCompras.Add(produto);
                    break;
                case 2:
                    Console.Write("Digite o nome do produto que deseja remover: ");
                    string produtoNome = Console.ReadLine();
                    foreach(Compras produtos in ListaCompras)
                    {
                        if (produtoNome.Equals(produtos.Nome))
                        {
                            ListaCompras.Remove(produtos);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 3:
                    foreach(Compras produtos in ListaCompras)
                    {
                        Console.WriteLine(produtos.ToString());
                    }
                    break;
                case 4:
                    verif = false;
                    break;
            }
        }
    }
}

class Compras
{
    string nome;
    int quantidade;
    double valor;

    public Compras() { }

    public Compras(string nome, int quantidade, double valor)
    {
        this.nome = nome;
        this.quantidade = quantidade;
        this.valor = valor;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Quantidade
    {
        get { return quantidade; }
        set { quantidade = value; }
    }
    public double Valor
    {
        get{ return valor; }
        set{ valor = value; }
    }
    public override string ToString()
    {
        string formatacao = $"Produto: {Nome}| Quantidade: {Quantidade}| Valor(R$): {Valor}";
        return formatacao;
    }
}