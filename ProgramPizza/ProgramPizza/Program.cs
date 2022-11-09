class Program
{
    public static void Main()
    {
        Console.WriteLine("Podaj pizz: (a,b,c)||(a b c)||(a;b;c) ");
        string pizze = Console.ReadLine();
        string[] listaPizz = pizze.Split(',', ' ', ';');


        foreach (var item in listaPizz)
        {
            Console.WriteLine($"Pizza {item}");
        }
    }
}