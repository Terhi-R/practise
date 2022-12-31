using mvcDotNetTrainingGround.Models;

namespace mvcDotNetTrainingGround.Tests;

public class DevelopersControllerTest
{
    [Fact]
    public void IsDeveloperFunctioning()
    {
        //act
        var developer = new Developer() { Id = 4, Name = "Hilla", Email = "Hilla@hotmail.com" };

        //assert
        Assert.Equal(developer.Name, "Hilla");
    }

    public void isCreateReturningBadRequest()
    {
        //arrange
        // var mockRepo = new Mock<Db>();
        //act

        //assert

    }
}