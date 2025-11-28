class Exercicio2
{
    public static float ConversorCelsius()
    {
        float temperatura = 0;
        while (true)
        {
            try
            {
                Console.Write("Digite um número: ");
                temperatura = float.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato incorreto.");
                continue;
            }
        }
        return temperatura;
    }
    static void Main()
    {
        float temperatura = ConversorCelsius();
        Console.WriteLine(temperatura + " ºC");
    }
}