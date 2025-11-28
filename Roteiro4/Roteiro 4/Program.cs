//Polimorfismo de subtipo
/*class Animal
{
    public virtual void Falar()
    {
        Console.WriteLine("Animal faz um som");
    }
}
class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine("Cachorro late");
    }
}
class Gato : Animal
{
    public override void Falar()
    {
        Console.WriteLine("Gato mia");
    }
}*/
class Program // Main metodo
{
    static void Main()
    {
        /*Animal animal1 = new Cachorro();
        Animal animal2 = new Gato();
        animal1.Falar();
        animal2.Falar();*/

        /*IAnimal coyote = new Coyote();
        IAnimal tigre = new Tigre();
        coyote.Falar();
        tigre.Falar();*/

        //Exercicio 1
        /*
        Pagamento[] pagamentos = new Pagamento[3];
        pagamentos[0] = new CartaoCredito();
        pagamentos[1] = new BoletoBancario();
        pagamentos[2] = new Pix();
        foreach (Pagamento p in pagamentos)
        {
            p.ProcessarPagamento();
        }*/
        /*
        Cachorro dog = new Cachorro { Nome = "Rex" };
        dog.EmitirSom(); // Saída: Som genérico de animal.
        dog.Dormir(); // Saída: Rex está dormindo...
        Gato cat = new Gato { Nome = "Whiskers" };
        cat.EmitirSom(); // Saída: Som genérico de animal.
        cat.Dormir(); // Saída: Whiskers está dormindo...*/

        Gerente gerente = new Gerente { funcao = "Gerente", salario = 5000 };
        Programador programador = new Programador { funcao = "Programador", salario = 3000 };
        gerente.CalcularSalario();
        programador.CalcularSalario();


    }
}// Main metodo//Polimorfismo de interfacepublic interface IAnimal
{
    void Falar();
}class Coyote : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("Coyote late");
    }
}class Tigre : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("Tigre ruge");
    }
}//Exercicio 1public class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Metodos de pagamento");
    }
}public class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagando com Cartao de credito");
    }
}public class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagando com Boleto bancario");
    }
}public class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagando com Pix");
    }
}//classes Abstratas// Classe abstrata com métodos concretos
abstract class Animal
{
    public string Nome { get; set; }
    // Método concreto (com implementação)
    public void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal.");
    }
    // Método concreto
    public void Dormir()
    {
        Console.WriteLine($"{Nome} está dormindo...");
    }
}
// Classe Cachorro herdando de Animal sem sobrescrever métodos
class Cachorro : Animal
{
    // Nenhum método precisa ser sobrescrito
}
// Classe Gato herdando de Animal sem sobrescrever métodos
class Gato : Animal
{
    // Nenhum método precisa ser sobrescrito
}

//Exercicio 2

abstract class Funcionario
{
    public string funcao { get; set; }
    public int salario { get; set; }

    public void CalcularSalario()
    {
        Console.WriteLine($"Função: {funcao} ,salario: {salario}");
    }
}
class Gerente : Funcionario
{

}
class Programador : Funcionario
{

}