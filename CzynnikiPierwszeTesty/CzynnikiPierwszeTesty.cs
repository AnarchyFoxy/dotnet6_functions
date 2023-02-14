using Xunit;
using BibliotekaCzynnikiPierwsze;

namespace CzynnikiPierwszeTesty;

public class Czynniki_pierwsze_testy
{
    [Fact]
    public void Czynniki_pierwsze_z_40()
    {
        //arrange

        int number = 40;
        string expected = "5 x 2 x 2 x 2";

        //act
        string actual = Czynniki_pierwsze.Czynniki_Pierwsze(number);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Czynniki_pierwsze_z_99()
    {
        // arrange
        int number = 99;
        string expected = "11 x 3 x 3";

        // act

        string actual = Czynniki_pierwsze.Czynniki_Pierwsze(number);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Czynniki_pierwsze_z_519()
    {
        // arrange
        int number = 519;
        string expected = "173 x 3";

        // act

        string actual = Czynniki_pierwsze.Czynniki_Pierwsze(number);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Czynniki_pierwsze_z_997()
    {
        // arrange
        int number = 997;
        string expected = "997";

        // act
        string actual = Czynniki_pierwsze.Czynniki_Pierwsze(number);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Czynniki_pierwsze_z_1000()
    {
        // arrange
        int number = 1000;
        string expected = "5 x 5 x 5 x 2 x 2 x 2";

        // act
        string actual = Czynniki_pierwsze.Czynniki_Pierwsze(number);

        // assert
        Assert.Equal(expected, actual);
    }
}
