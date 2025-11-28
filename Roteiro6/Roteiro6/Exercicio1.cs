class Exercicio1
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine());
            string mensagemDeErro = "";
            if (nome == "")
            {
                mensagemDeErro += "Nome não pode ser vazio.\n";
            }
            if (preco <= 0)
            {
                mensagemDeErro += "Preço não pode ser negativo ou Zero.\n";
            }
            if (mensagemDeErro != "")
            {
                throw new FormatException(mensagemDeErro);
            }
            else
            {
                Console.WriteLine($"Nome: {nome}, Preço: {preco}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        { 
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}