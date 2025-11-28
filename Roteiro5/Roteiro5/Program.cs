// 1 - Class Math
/*class Matematica
{
    static void Main()
    {
        double raiz = Math.Sqrt(25);
        double potencia = Math.Pow(2, 3);
        double seno = Math.Sin(Math.PI / 2);

        Console.WriteLine($"Raiz: {raiz}, Potência: {potencia}, Seno: {seno}");
    }
}*/

class Exercicio1
{
    static void Main()
    {
        decimal numero = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Valor padrão: {numero}");
        Console.WriteLine($"Valor com arrendodamento padrão: " + Math.Round(numero));
        Console.WriteLine($"Valor com arrendodamento para baixo: " + Math.Floor(numero));
        Console.WriteLine($"Valor com arrendodamento para cima: " + Math.Ceiling(numero));
        Console.WriteLine($"Valor com truncamento: " + Math.Truncate(numero));
    }
}

// 2 - Class String e operações
/*class FormatacaoDeStrings
{
    static void Main()
    {
        string nome = "Maria";
        Console.WriteLine("Usando o ToUpper: " + nome.ToUpper());
        Console.WriteLine("Usando o ToLower: " + nome.ToLower());
        Console.WriteLine("Usando o Contains: " + nome.Contains("a"));
        Console.WriteLine("Usando o Substring: " + nome.Substring(0,4));
        Console.WriteLine("Usando o Replace: " + nome.Replace("a","o"));
        string[] letras = nome.Split("r");
        Console.Write("Usando o Split: ");
        foreach (var word in letras)
        {
            Console.Write(word+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Usando o Trim: " + nome.Trim('a'));
        Console.WriteLine("Usando o StartsWith: " + nome.StartsWith("m"));
        Console.WriteLine("Usando o EndsWith: " + nome.EndsWith("a"));
    }
}*/

//Exercicio 2
/*class Exercicio2
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase com , e espaços:");
        //string frase = Console.ReadLine();
        string frase = "         ,Meu,nome,é,Igor,         ";
        Console.Write(frase.Trim());
        string[] palavras = frase.Trim().Split(',');
        foreach (var palavra in palavras)
        {
            Console.WriteLine(palavra);
        }
        Console.WriteLine(frase.Trim().Replace("Igor","Ian"));
        Console.WriteLine(frase.Trim().StartsWith(','));
        Console.WriteLine(frase.Trim().EndsWith(' '));
    }
}*/

// 3 - Formatação
/*class Formatacao
{
    static void Main()
    {
        double valor = 1234.5678;
        int numero = 42;
        Console.WriteLine($"Valor formatado: {valor:F2}");
        Console.WriteLine($"Número com zeros: {numero:D4}");
        string nome = "Maria";
        int idade = 28;
        double saldo = 1234.5678;
        DateTime hoje = DateTime.Now;

        string mensagem = string.Format("Nome: {0}, Idade: {1}, Saldo: R$ {2:F2}, Data: {3:dd/MM/yyyy}", nome, idade, saldo, hoje);
        Console.WriteLine(mensagem);
    }
}*/

// 4 - Datas e Calendários

/*class DataECalendarios
{
    static void Main()
    {
        DateTime agora = DateTime.Now;
        Console.WriteLine("Agora "+ agora);

        DateTime aniversario = new DateTime(2001,7,13);
        TimeSpan idade = agora - aniversario;
        Console.WriteLine($"Dias de vida: {idade.TotalDays:F0}");
        Console.WriteLine($"Ano: {agora.Year}, Mês: {agora.Month}");
        Console.WriteLine(agora.ToString("dd/MM/yyyy HH:mm"));
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(DateTime.UtcNow);
    }
}*/

//Exercicio 4
/*using System.Globalization;

class Exercicio4
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a data do compromisso (formato dd/MM/yyyy HH:mm):");
        string dataTexto = Console.ReadLine();
        DateTime compromisso = DateTime.ParseExact(dataTexto, "dd/MM/yyyy HH:mm", null);
        DateTime hoje = DateTime.Now;
        TimeSpan faltam = compromisso - hoje;
        Console.WriteLine(
            string.Format("Olá {0}!\nSeu compromisso será em {1} dias.\nData marcada: {2} às {3}",
            nome, faltam.Days, compromisso.ToString("dd/MM/yyyy"), compromisso.ToString("HH:mm")));
    }
}*/