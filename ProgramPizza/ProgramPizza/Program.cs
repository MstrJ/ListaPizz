class MojaPizza
{
    private string[] listaPizz;
    public MojaPizza()
    {
        listaPizz = new string[0];
    }
    public MojaPizza(string[] listaPizz)
    {
        this.listaPizz = listaPizz;
    }

    public void Pokaz()
    {
        if (listaPizz.Length > 0)
        {
            Console.WriteLine("Moje Ulubione Pizze:");
            foreach (var item in listaPizz)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}



class Program
{
    public static void Main()
    {
        Console.WriteLine("Podaj pizz: (a,b,c)||(a b c)||(a;b;c) ");
        string pizze = Console.ReadLine();
        string[] listaPizz = pizze.Split(',', ' ', ';');

        var mojePizze = new MojaPizza(listaPizz);
        mojePizze.Pokaz();
    }

    // 1. Zrob classe o nazwie MojaPizza
    // 2. Zawiera ona metode dzieki ktorej pokazujemy pizze , w ktorej przesylamy parametr listaPizz
    // 3  Dodaj cos od siebie :)
}