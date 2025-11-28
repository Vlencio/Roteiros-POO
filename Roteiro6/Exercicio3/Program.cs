using static System.Runtime.InteropServices.JavaScript.JSType;

class Exercicio3
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite um numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"Número digitado: {numero}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
                continue;
            }
        }
    }
}