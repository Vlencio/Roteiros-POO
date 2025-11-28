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
    public class PAC_MAN
    {
        public static void Main()
        {
        Fantasminhas fantasminhas = new Fantasminhas();

        fantasminhas.habilidade = "matar";
        fantasminhas.nick = "EduardoGol";
        fantasminhas.cor = "Branco";
        fantasminhas.GerarFantasma();
        fantasminhas.Mover("direita");
        }
    }