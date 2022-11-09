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
    public bool Poprawnosc()
    {
        if (listaPizz.Length > 0) return true;
        else return false;
    }

    public void Pokaz()
    {
        Console.WriteLine($"Dlugosc listy Pizz: {listaPizz.Length}");
        if (Poprawnosc())
        {
            Console.WriteLine("Moje Ulubione Pizze:");
            foreach (var item in listaPizz)
            {
                Console.Write($"\t{item}");
            }
        }
        Console.WriteLine();
    }


    public void LosujPizze()
    {
        if (Poprawnosc())
        {
            var rand = new Random();
            int i = rand.Next(listaPizz.Length - 1);
            Console.WriteLine($"Twoja Losowa Pizza to {listaPizz[i]}");
        }
    }
}



class Program
{
    public static void Main()
    {
        Console.WriteLine("Podaj pizz: (a,b,c)||(a b c)||(a;b;c) ");
        string pizze = Console.ReadLine() ;
        string[] listaPizz = !string.IsNullOrWhiteSpace(pizze) ? pizze.Split(',', ' ', ';') : new string[] {"zle wpisales"};

        var mojePizze = new MojaPizza(listaPizz);
        mojePizze.Pokaz();

        mojePizze.LosujPizze();
    }

    // 1. Zrob classe o nazwie MojaPizza
    // 2. Zawiera ona metode dzieki ktorej pokazujemy pizze , w ktorej przesylamy parametr listaPizz
    // 3  Dodaj cos od siebie :)
}