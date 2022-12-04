namespace TrainingGround.Tests;

public class exceptionsTests
{

    [Fact]
    public void notHandlingAnException()
    {
        try
        {

            var i = 1;
            var result = 14 / (i - 1);
        }
        catch (System.DivideByZeroException ex)
        {
            Assert.IsType<DivideByZeroException>(ex);
        }
    }

    [Fact]
    public void gettingAgeFromPerson()
    {
        try
        {
            var p = new Person(2023);
            var age = p.GetAge(2022);
        }
        catch (System.Exception ex)
        {
            Assert.Equal("Not born yet", ex.Message);
            return;
        }

        Assert.True(false, "Expected exception didn't happen");
    }

}