/*
1. Peça ao usuário para digitar uma palavra.
2. Use uma Stack<char> para empilhar cada caractere da palavra.
3. Desempilhe os caracteres para formar e exibir a palavra invertida.
*/
class Program
{
    static void Main()
    {
        Stack<char> Letras = new Stack<char>();
        char novaLetra;
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        foreach(char c in palavra)
        {
            Letras.Push(c);
        }
        Console.Write($"Palavra original: {palavra}\n");
        Console.Write("Palavra invertida: ");
        while (Letras.Count > 0)
        {
            char novaPalavra = Letras.Pop();
            Console.Write($"{novaPalavra}");
        }
    }
}