public class PersonTests
{

    [Fact]
    public void create_person_using_parameterless_constructor()
    {
        //act
        var p = new Person("Terhi");

        //assert
        Assert.NotNull(p);
        Assert.Equal("Terhi", p.Name);
    }


    [Theory]
    [InlineData(1972, 2022, 50)]
    [InlineData(1982, 2022, 40)]
    [InlineData(1992, 2022, 30)]
    [InlineData(2022, 2022, 0)]
    public void calculateAge(int born, int current, int expected)
    {

        var year = new Person();
        var result = year.GetAge(born, current);


        Assert.Equal(expected, result);

    }
}