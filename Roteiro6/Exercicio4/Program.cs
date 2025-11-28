class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException() : base("Erro: Idade mínima para acesso é 18 anos.") { }
}

class Exercicio4
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade < 18)
                {
                    throw new IdadeInvalidaException();
                }
                else
                {
                    Console.WriteLine("Acesso Permitido.");
                    break;
                }
            }
            catch (IdadeInvalidaException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Formato inválido.");
            }
        }
    }
}