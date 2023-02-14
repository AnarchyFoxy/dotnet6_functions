using CS10;
using static System.Console;

WriteLine("W metodzie Main");
Alfa();

static void Alfa()
{
    WriteLine("W metodzie Alfa");
    Wita();
}

static void Wita()
{
    WriteLine("W metodzie Wita");
    try
    {
        Kalkulator.Ghama();
    }
    catch (Exception wyjatek)
    {
        WriteLine($"Złapano gada: {wyjatek.Message}");
       
    }
}