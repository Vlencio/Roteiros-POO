//using System.Security.Cryptography.X509Certificates;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
    public void ApresentarCargo()
    {
        Console.WriteLine($"E meu cargo é {Cargo}");
    }

    public void ApresentarSalario()
    {

        switch (Cargo)
        {
            case "Gerente":
                Console.WriteLine("Gerente: R$ 10.000,00");
                break;
            case "Desenvolvedor":
                Console.WriteLine("Desenvolvedor: R$ 5.000,00");
                break;
            case "Estagiario":
                Console.WriteLine("Estagiário: R$ 100,00");
                break;
        }
    }
}

public class Fantasminhas
{
    public string habilidade;
    public string nick;
    public string cor;

    public void GerarFantasma()
    {
        Console.WriteLine($"Habilidade: {habilidade}, Nick: {nick}, Cor: {cor}.");
    }

    public void Mover(string parametro)
    {
        Console.WriteLine($"O {nick} moveu para {parametro}");
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new();
        Pessoa p2 = new();
        Pessoa p3 = new();

        p1.Nome = "Joao";
        p1.Idade = 24;
        p1.Cargo = "Gerente";

        p2.Nome = "Pedro";
        p2.Idade = 20;
        p2.Cargo = "Desenvolvedor";

        p3.Nome = "Paulo";
        p3.Idade = 18;
        p3.Cargo = "Estagiario";

        p1.Apresentar();
        p1.ApresentarCargo();
        p1.ApresentarSalario();

        p2.Apresentar();
        p2.ApresentarCargo();
        p2.ApresentarSalario();

        p3.Apresentar();
        p3.ApresentarCargo();
        p3.ApresentarSalario();

        Console.WriteLine();

        Fantasminhas fantasminhas = new Fantasminhas();

        fantasminhas.habilidade = "matar";
        fantasminhas.nick = "EduardoGol";
        fantasminhas.cor = "Branco";
        fantasminhas.GerarFantasma();
        fantasminhas.Mover("direita");
    }
}