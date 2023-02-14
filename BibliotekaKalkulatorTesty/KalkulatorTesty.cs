using CS10;
using Xunit;

namespace BibliotekaKalkulatorTesty;

public class KalkulatorTesty
{
    [Fact]
    public void Test_doda_2_i_2()
    {
        //arrange

        double a = 2;
        double b = 2;
        double oczekiwane = 4;
        var kal = new Kalkulator();

        //act
        double wynik = kal.Dodaj(a, b);

        //Assert
        Assert.Equal(oczekiwane, wynik);
    }

    [Fact]
    public void Test_dodaj_2_i_3()
    {
        // Arrange

        double a = 2;
        double b = 3;
        double oczekiwane = 5;
        var kal = new Kalkulator();

        //act
        double wynik = kal.Dodaj(a, b);

        //assert
        Assert.Equal(oczekiwane, wynik);
    }
}
