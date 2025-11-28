using System.Runtime.CompilerServices;

class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;
        this.preco = preco;
    }

    public string Nome { get; set; }

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Valor negativo");
                preco = 0;
            }
            else
            {
                preco = value;
            }
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O nome do produto é: {nome} e o preço é: {preco}");
    }
}

class Carro
{
    private string modelo;
    private int velocidadeAtual;

    public Carro()
    {
    }
    public Carro(string modelo)
    {
        this.Modelo = modelo;
    }
    public string Modelo { get => modelo; set => modelo = value; }

    public int VelocidadeAtual
    {
        get { return velocidadeAtual; }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Velocidade nao pode ser menor que 0.");
                velocidadeAtual = 0;
            }
            else
            {
                velocidadeAtual = value;
            }
        }
    }
    public void Acelerar(int valor)
    {
        velocidadeAtual += valor;
    }
    public void Frear(int valor)
    {
        velocidadeAtual -= valor;
        if (velocidadeAtual < 0)
        {
            Console.WriteLine("Velocidade não pode ser menor que 0");
            velocidadeAtual = 0;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
           Produto p = new Produto("Celular", 1500);
           p.ExibirDetalhes();
           p.Preco = -200;

        /*
        Carro c = new Carro("Ferrari");
        c.Acelerar(50);
        Console.WriteLine(c.VelocidadeAtual);
        c.Frear(30);
        Console.WriteLine(c.VelocidadeAtual);
        c.Frear(50);*/
        
        /*
        Elevador e = new Elevador(10);
        e.Subir();
        e.Subir();
        Console.WriteLine(e.AndarAtual);
        e.Descer();
        Console.WriteLine(e.AndarAtual);
        e.Descer();
        e.Descer();*/
    }
}

class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.TotalAndares = totalAndares;
    }

    public int AndarAtual
    {
        get { return andarAtual; }

        set
        {
            andarAtual = value;
        }
    }
    public int TotalAndares { get => totalAndares; set => totalAndares = value; }

    public void Subir()
    {
        andarAtual += 1;
    }
    public void Descer()
    {
        if (andarAtual == 0)
        {
            Console.WriteLine("Nao existe andar negativo");
            //andarAtual = 0;
        }
        else
        {
            andarAtual -= 1;
        }
    }
}
