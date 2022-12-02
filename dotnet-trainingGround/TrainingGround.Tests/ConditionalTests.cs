namespace TrainingGround.Tests;

public class ConditionalTests
{
    [Fact]
    public void shouldBeKidWhenYoungerThan18()
    {
        var p = new Person(2005);
        var category = AgeCalculator.GetAgeCategory(p, 2022);
        Assert.Equal(AgeCategory.Kid, category);
    }

    [Fact]
    public void shouldBeAdultWhenOlderThan18()
    {
        //arrange
        var p = new Person(2002);
        //act
        var category = AgeCalculator.GetAgeCategory(p, 2022);
        //assert
        Assert.Equal(AgeCategory.Adult, category);
    }

    public void when50ThenPrimeAge()
    {
        //arrange
        var p = new Person(1972);
        //act
        var category = AgeCalculator.GetAgeCategory(p, 2022);
        //assert
        Assert.Equal(AgeCategory.Prime, category);
    }

    [Fact]
    public void returnUnder18ForKid()
    {
        var span = AgeCalculator.GetAgeSpan(AgeCategory.Kid);
        Assert.Equal("You are under 18 years old", span);
    }
    [Fact]
    public void return18OrOverForAdult()
    {
        var span = AgeCalculator.GetAgeSpan(AgeCategory.Adult);
        Assert.Equal("You are an adult!", span);
    }
    [Fact]
    public void returnAtPrimeAge()
    {
        var span = AgeCalculator.GetAgeSpan(AgeCategory.Prime);
        Assert.Equal("You are at prime age!", span);
    }

    [Theory]
    [InlineData(2005, 2022, "You are under 18 years old")]
    [InlineData(2004, 2022, "You are an adult!")]
    [InlineData(1972, 2022, "You are at prime age!")]
    public void whatAgeAreYou(int born, int current, string expected)
    {
        //arrange
        var category = AgeCalculator.GetAgeCategory(new Person(born), current);
        var result = AgeCalculator.GetAgeSpan(category);

        //assert
        Assert.Equal(expected, result);
    }

}