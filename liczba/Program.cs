Random r = new Random();
int num = r.Next(1, 10);
int guess = 0;
bool win = false;

Console.WriteLine("Witaj w grze pod tytułem zgadnij liczbe!");
Console.WriteLine("Wylosowałem liczbę z przedziału od 1 do 10.");
Console.WriteLine("Wprowadz liczbe:");

while (!win)
{
    string read = Console.ReadLine();
    bool ok = int.TryParse(read, out guess);
    if (!ok)
    {
        Console.WriteLine("Wprowadzona wartośc nie jest liczbą.");
        continue;
    }
    if (guess < 1 || guess > 10)
    {
        Console.WriteLine("Wprowadzona liczba nie mieści się w zakresie! Spróbuj ponownie.");
    }
    else if (guess < num)
    {
        Console.WriteLine("Wylosowana liczba jest większa od podanej");
    }
    else if (guess > num)
    {
        Console.WriteLine("Wylosowana liczba jest mniejsza od podanej");
    }
    else
    {
        Console.WriteLine("Wygrałeś!");
        break;
    }
}
