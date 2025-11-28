/*
1. Peça ao usuário para digitar vários números inteiros (um por vez, e digitar 0 para
parar).
2. Armazene apenas os números únicos digitados (ignore duplicatas).
3. Ao final (quando o usuário digitar 0), exiba todos os números únicos que foram
digitados. 
*/
class Program
{
    static void Main()
    {
        HashSet<int> numeros = new HashSet<int>();
        while (true)
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            if(numero != 0)
            {
                numeros.Add(numero);
            }
            else
            {
                break;
            }
        }
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}