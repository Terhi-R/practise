namespace TrainingGround.Tests;

public class CollectionTests
{
    [Fact]
    public void anArrayHasALength()
    {
        //act
        var arrayOfIntegers = new int[5];
        var arrayOfIntegersWithValues = new int[] { 1, 2, 3 };
        var arrayOfStrings = new string[] { "Name 1", "Name 2", };

        //assert
        Assert.Equal(5, arrayOfIntegers.Length);
        Assert.Equal(3, arrayOfIntegersWithValues.Length);
        Assert.Equal(2, arrayOfStrings.Length);
    }

    [Fact]
    public void gettingItemsOut()
    {

        var arrString = new string[] { "Name 1", "Name 2" };
        Assert.Equal("Name 1", arrString[0]);
        Assert.Equal("Name 2", arrString[1]);
    }

    [Fact]
    public void showingObjectInitializer()
    {
        var a = new Address();
        a.Street = "B Street";
        a.StreetNo = 22;
        a.City = "Malmö";

        var b = new Address
        {
            Street = "B Street",
            StreetNo = 22,
            City = "Malmö"
        };

        Assert.Equal(a.Street, b.Street);
        Assert.Equal(a.StreetNo, b.StreetNo);
        Assert.Equal(a.City, b.City);

    }
}