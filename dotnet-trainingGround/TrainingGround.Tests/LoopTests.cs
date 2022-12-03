namespace TrainingGround.Tests;

public class LoopTests
{

    [Fact]
    public void whileLoop()
    {
        //arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };

        //act
        var i = 0;
        while (i < ints.Length)
        {
            var currentValueInTheLoop = ints[i];

            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

            //assert
            Assert.Equal(i + 1, currentValueInTheLoop);

            i = i + 1;
        }
    }

    [Fact]
    public void forLoop()
    {
        //arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };
        //act
        for (var i = 0; i < ints.Length; i++)
        {
            var currentValueInTheLoop = ints[i];

            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

            //assert
            Assert.Equal(i + 1, currentValueInTheLoop);
        }
    }

    [Fact]
    public void forEachLoop()
    {
        //arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };
        var i = 0;

        //act
        foreach (var currentValueInTheLoop in ints)
        {
            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

            //assert
            Assert.IsType<int>(currentValueInTheLoop);
        }
    }

    [Fact]
    public void forEachLoopForAddress()
    {
        //arrange
        var addressList = new List<Address>();
        addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 3 });

        //act
        var foundIt = false;
        foreach (var currentValueInTheLoop in addressList)
        {
            if (currentValueInTheLoop.StreetNo == 2)
            {
                foundIt = true;
                break;
            }

        }
        //assert
        Assert.True(foundIt);
    }

    [Fact]
    public void forEachLoopContinue()
    {
        //arrange
        var addressList = new List<Address>();
        addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 3 });

        //act
        var notFound = false;
        foreach (var currentValueInTheLoop in addressList)
        {
            if (currentValueInTheLoop.StreetNo == 1)
            {
                continue;
            }
            if (currentValueInTheLoop.StreetNo != 1)
            {
                notFound = true;
            }
            Console.WriteLine(currentValueInTheLoop.StreetNo);
        }
        //assert
        Assert.True(notFound);
    }

}