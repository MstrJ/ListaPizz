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

    // 1. Zrob classe o nazwie MojaPizza
    // 2. Zawiera ona metode dzieki ktorej pokazujemy pizze , w ktorej przesylamy parametr listaPizz
    // 3  Dodaj cos od siebie :)
}