using BibliotekaCzynnikiPierwsze;
using static System.Console;

Write("Wpisz liczbę między 1 i 1000: ");

if (int.TryParse(ReadLine(), out int number))
{
    WriteLine(format: "Czynniki pierwsze z {0} to {1}",
        arg0: number,
        arg1: Czynniki_pierwsze.Czynniki_Pierwsze(number));
}