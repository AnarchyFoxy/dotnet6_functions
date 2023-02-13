using static System.Console;

Tabliczka_mnozenia(7);
// Output:
/*
1 x 7 = 7
2 x 7 = 14
3 x 7 = 21
4 x 7 = 28
5 x 7 = 35
6 x 7 = 42
7 x 7 = 49
8 x 7 = 56
9 x 7 = 63
10 x 7 = 70
 */

decimal podatek = Podatek_VAT(kwota: 149, kod_regionu: "HU");
WriteLine($"Musisz zapłacić {podatek} podatku VAT");
// Output:
// Musisz zapłacić 40.23 podatku VAT

Zmien_glowne_na_porzadkowe();
// Output:
// 1st 2nd 3rd 4th 5th 6th 7th 8th 9th 10th 11th 12th 13th 14th 15th 16th 17th 18th 19th 20th 21st 22nd 23rd 24th 25th 26th 27th 28th 29th 30th 31st 32nd 33rd 34th 35th 36th 37th 38th 39th 40th 


Oblicz_silnie();
// Output:
/*
1! = 1
2! = 2
3! = 6
4! = 24
5! = 120
6! = 720
7! = 5,040
8! = 40,320
9! = 362,880
10! = 3,628,800
11! = 39,916,800
12! = 479,001,600
13! jest zbyt wielka dla 32-bitowej zmiennej.
14! jest zbyt wielka dla 32-bitowej zmiennej.
 */

Uruchom_Fib_imperatywna();
// Output:
/*
1. pozycja w ciągu Fibonacciego to 0.
2. pozycja w ciągu Fibonacciego to 1.
3. pozycja w ciągu Fibonacciego to 1.
4. pozycja w ciągu Fibonacciego to 2.
5. pozycja w ciągu Fibonacciego to 3.
6. pozycja w ciągu Fibonacciego to 5.
7. pozycja w ciągu Fibonacciego to 8.
8. pozycja w ciągu Fibonacciego to 13.
9. pozycja w ciągu Fibonacciego to 21.
10. pozycja w ciągu Fibonacciego to 34.
11. pozycja w ciągu Fibonacciego to 55.
12. pozycja w ciągu Fibonacciego to 89.
13. pozycja w ciągu Fibonacciego to 144.
14. pozycja w ciągu Fibonacciego to 233.
15. pozycja w ciągu Fibonacciego to 377.
16. pozycja w ciągu Fibonacciego to 610.
17. pozycja w ciągu Fibonacciego to 987.
18. pozycja w ciągu Fibonacciego to 1,597.
19. pozycja w ciągu Fibonacciego to 2,584.
20. pozycja w ciągu Fibonacciego to 4,181.
21. pozycja w ciągu Fibonacciego to 6,765.
22. pozycja w ciągu Fibonacciego to 10,946.
23. pozycja w ciągu Fibonacciego to 17,711.
24. pozycja w ciągu Fibonacciego to 28,657.
25. pozycja w ciągu Fibonacciego to 46,368.
26. pozycja w ciągu Fibonacciego to 75,025.
27. pozycja w ciągu Fibonacciego to 121,393.
28. pozycja w ciągu Fibonacciego to 196,418.
29. pozycja w ciągu Fibonacciego to 317,811.
30. pozycja w ciągu Fibonacciego to 514,229.
 */

Uruchom_Fib_funkcyjna();
// Output:
/*
1. pozycja w ciągu Fibonacciego to 0
2. pozycja w ciągu Fibonacciego to 1
3. pozycja w ciągu Fibonacciego to 1
4. pozycja w ciągu Fibonacciego to 2
5. pozycja w ciągu Fibonacciego to 3
6. pozycja w ciągu Fibonacciego to 5
7. pozycja w ciągu Fibonacciego to 8
8. pozycja w ciągu Fibonacciego to 13
9. pozycja w ciągu Fibonacciego to 21
10. pozycja w ciągu Fibonacciego to 34
11. pozycja w ciągu Fibonacciego to 55
12. pozycja w ciągu Fibonacciego to 89
13. pozycja w ciągu Fibonacciego to 144
14. pozycja w ciągu Fibonacciego to 233
15. pozycja w ciągu Fibonacciego to 377
16. pozycja w ciągu Fibonacciego to 610
17. pozycja w ciągu Fibonacciego to 987
18. pozycja w ciągu Fibonacciego to 1,597
19. pozycja w ciągu Fibonacciego to 2,584
20. pozycja w ciągu Fibonacciego to 4,181
21. pozycja w ciągu Fibonacciego to 6,765
22. pozycja w ciągu Fibonacciego to 10,946
23. pozycja w ciągu Fibonacciego to 17,711
24. pozycja w ciągu Fibonacciego to 28,657
25. pozycja w ciągu Fibonacciego to 46,368
26. pozycja w ciągu Fibonacciego to 75,025
27. pozycja w ciągu Fibonacciego to 121,393
28. pozycja w ciągu Fibonacciego to 196,418
29. pozycja w ciągu Fibonacciego to 317,811
30. pozycja w ciągu Fibonacciego to 514,229
 */


// Funkcje:
// 1. 
static void Tabliczka_mnozenia(byte liczba)
{
    WriteLine($"Ro jest sekwencja mnożenia dla liczby {liczba}");
    for (int wiersz = 1; wiersz <= 12; wiersz++)
    {
        WriteLine($"{wiersz} x {liczba} = {wiersz * liczba}");
    }
}

// 2.
static decimal Podatek_VAT(decimal kwota, string kod_regionu)
{
    decimal stawka = 0.0M;
    switch (kod_regionu)
    {
        case "CH":
            stawka = 0.8M;
            break;
        case "DK":
        case "NO":
            stawka = 0.25M;
            break;
        case "GB":
        case "FR":
            stawka = 0.2M;
            break;
        case "HU":
            stawka = 0.27M;
            break;
        case "OR":
        case "AK":
        case "MT":
            stawka = 0.0M;
            break;
        case "ND":
        case "WI":
        case "ME":
        case "VA":
            stawka = 0.05M;
            break;
        case "CA":
            stawka = 0.0825M;
            break;
        default: //Poland
            stawka = 0.23M;
            break;
    }
    return kwota * stawka;
}

// 3.1
///<summary>
///Podaj funkcji 32-bitową liczbę, a ona zamieni ją na liczebnik porządkowy
///</summary>
///<param name="liczba"> Liczba w postaci liczebnika głównego (1, 2, 3, itd.)</param>
///<returns>Liczba w postaci liczebnika porządkowego (1st, 2nd, 3rd, itd.)</returns>
static string Glowne_na_porzadkowe(int liczba)
{
    switch (liczba)
    {
        case 11:
        case 12:
        case 13:
            return $"{liczba}th";
        default:
            int ostatnia_cyfra = liczba % 10;
            string przyrostek = ostatnia_cyfra switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{liczba}{przyrostek}";
    }
}

//3.2
static void Zmien_glowne_na_porzadkowe()
{
    for (int liczba = 1; liczba <= 40; liczba++)
    {
        Write($"{Glowne_na_porzadkowe(liczba)} ");
    }
    WriteLine();
}

// 4.1
static int Silnia(int liczba)
{
    if (liczba < 1)
    {
        return 0;
    }
    else if (liczba == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
            return liczba * Silnia(liczba - 1);
        }
    }
}

//4.2
static void Oblicz_silnie()
{
    for (int i = 1; i < 15; i++)
    {
        try
        {
            WriteLine($"{i}! = {Silnia(i):N0}");
        }
        catch (OverflowException)
        {
            WriteLine($"{i}! jest zbyt wielka dla 32-bitowej zmiennej.");
        }
    }
}

// 5.1
static int Fib_imperatywna(int pozycja)
{
    if (pozycja == 1)
    {
        return 0;
    }
    else if (pozycja == 2)
    {
        return 1;
    }
    else
    {
        return Fib_imperatywna(pozycja - 1) + Fib_imperatywna(pozycja - 2);
    }
}

// 5.2
static void Uruchom_Fib_imperatywna()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("{0}. pozycja w ciągu Fibonacciego to {1:N0}.",
            arg0: i,
            arg1: Fib_imperatywna(pozycja: i));
    }
}

// 5.3
static int Fib_funkcyjna(int pozycja) =>
    pozycja switch
    {
        1 => 0,
        2 => 1,
        _ => Fib_funkcyjna(pozycja - 1) + Fib_funkcyjna(pozycja - 2)
    };

// 5.4
static void Uruchom_Fib_funkcyjna()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("{0}. pozycja w ciągu Fibonacciego to {1:N0}",
            arg0: i,
            arg1: Fib_funkcyjna(pozycja: i));
    }
}