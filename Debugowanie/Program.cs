using static System.Console;

double a = 4.5;
double b = 2.5;
double wynik = Dodaj(a, b);
WriteLine($"{a} + {b} = {wynik}");
// 4.5 + 2.5 = 11.25 - error- it should be 7, not 11.25
// after debugging: 4.5 + 2.5 = 7


// Funkcje:
// 1.
static double Dodaj(double a, double b)
{
    //return a * b; // an error - multiplying instead of adding two elements
    return a + b; // after debugging
}