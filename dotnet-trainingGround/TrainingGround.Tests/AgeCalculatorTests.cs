namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    //arrange


    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {
        //act
        var age = AgeCalculator.GetAge(1972, 2022);
        //assert
        Assert.Equal(50, age);
    }
    [Fact]
    public void someone_born_2022_is_0_in_2022()
    {
        //act
        var age = AgeCalculator.GetAge(2022, 2022);
        //assert
        Assert.Equal(0, age);
    }
}