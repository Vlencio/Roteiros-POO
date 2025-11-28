using System;
// Hernaça entre classes Exercicio 1
public class Animal
{
    public string somGenerico;
}
public class Tigre : Animal
{
    public string somTigre;
    public void EmitirSomTigre()
    {
        Console.WriteLine($"Emitir som: {somGenerico}");
        Console.WriteLine($"Emitiu o som de: {somTigre}");
    }
}
// Composição entre classes Exercicio 2
public class Pedido
{
    public int itens { get; set; }
    public void EntregarPedido()
    {
        Console.WriteLine("Pedido entregue");
    }
}
public class Cliente
{
    // Composição: Um carro "tem um" motor
    private Pedido pedido;
    public Cliente()
    {
        pedido = new Pedido(); // Criando um motor dentro do carro
    }
    public void ReceberPedido()
    {
        pedido.EntregarPedido();
        Console.WriteLine("Pedido recebido");
    }
}

//Main metodo VVVVVVV
class HelloWorld
{
    static void Main()
    {
        //Exercicio 1
        /*Tigre tigre = new Tigre();
        tigre.somGenerico = "rrrrrrrrrrrr";
        tigre.somTigre = "AUAUAUAUAU";
        tigre.EmitirSomTigre();*/

        //Exercicio 2
        /*Cliente cliente = new Cliente();
        cliente.ReceberPedido();*/
        
        /*IAnimal animal1 = new Cachorro();
        IAnimal animal2 = new Gato();
        Pato pato = new Pato();
        
        animal1.Falar(); // Saída: Cachorro late
        animal1.Comer(); // Saída: Cachorro come
        animal2.Falar(); // Saída: Gato mia
        animal2.Comer(); // Saída: Gato
        pato.Nadar();
        pato.Voar();*/

        //Exercicio 3
        /*IVeiculo carro = new Carro();
        carro.Mover();
        IVeiculo bicicleta = new Bicicleta();
        bicicleta.Mover();*/

        //Exercicio 4
        Pato pato = new Pato();
        INadar peixe = new Peixe();
        IVoar aguia = new Aguia();
        pato.Nadar();
        pato.Voar();
        peixe.Nadar();
        aguia.Voar();
    }
}
//Main metodo ^^^^^^^

//Interface
public interface IAnimal
{
    void Falar();
    void Comer();
}
public class Cachorro : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("AUAUA");
    }
    public void Comer()
    {
        Console.WriteLine("Cachorro comendo ração");
    }
}
public class Gato : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("MIAU");
    }
    public void Comer()
    {
        Console.WriteLine("Gato comendo ração");
    }
}
//Multiplas Interfaces e Exercicio 4
public interface IVoar
{
    void Voar();
}
public interface INadar
{
    void Nadar();
}
public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("Pato esta voando");
    }
    public void Nadar()
    {
        Console.WriteLine("Pato esta nadando");
    }
}
public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("Aguia pode voar");
    }
}
public class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("Peixe pode nadar");
    }
}

//Exercicio 3
public interface IVeiculo
{
    void Mover();
}
public class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("Carro está se movendo");
    }
}
public class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("Bicicleta está se movendo");
    }
}