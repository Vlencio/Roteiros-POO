/*
1. Adicionar um novo produto (código e nome).
2. Buscar e exibir o nome de um produto pelo seu código.
3. Listar todos os códigos e nomes dos produtos cadastrados.
4. Verificar se um código de produto já existe antes de tentar adicionar. 
*/

class Program
{
    static void Main()
    {
        Dictionary<int, string> Produtos = new Dictionary<int, string>();
        bool verif = true;
        while (verif)
        {
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Adicionar:\n2 - Listar produtos pelo codigo\n3 - Listar todos\n4 - Finalizar");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o Codigo do produto: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite o Nome do produto: ");
                    string nome = Console.ReadLine();
                    Produtos.Add(codigo, nome);
                    break;
                case 2:
                    Console.Write("Digite o Codigo do produto que voce quer listar: ");
                    int buscarCodigo = int.Parse(Console.ReadLine());
                    foreach(KeyValuePair<int,string> par in Produtos)
                    {
                        if(par.Key == buscarCodigo)
                        {
                            Console.WriteLine(par.Value);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 3:
                    foreach(KeyValuePair<int,string> par in Produtos)
                    {
                        Console.WriteLine($"Codigo - {par.Key}| Nome: {par.Value}");
                    }
                    break;
                case 4:
                    verif = false;
                    break;
            }
        }
    }
}