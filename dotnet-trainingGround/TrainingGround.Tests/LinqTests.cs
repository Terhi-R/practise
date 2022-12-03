namespace TrainingGround.Tests;

public class LinqTests
{
    [Fact]
    public void notLinqMethod()
    {
        var nums = new List<int> { 3, 6, 23, 86, 4, 2, 56 };

        var overFifteen = new List<int>();
        foreach (var over in nums)
        {
            if (over > 15)
            {
                overFifteen.Add(over);
                continue;
            }
            Console.WriteLine(overFifteen);

        }
        Assert.Equal(3, overFifteen.Count);
    }

    [Fact]
    public void linqToFilterNumbers()
    {
        var numbers = new List<int> { 3, 45, 6, 78, 3, 46, 8, 94 };

        var over15 = numbers.FindAll(number => number > 15);
        Assert.Equal(4, over15.Count);
    }

    [Fact]
    public void linqToFindFirst()
    {
        var numbers = new List<int> { 3, 45, 6, 78, 3, 46, 8, 94 };
        var firstOver15 = numbers.Find(number => number > 15);

        Assert.Equal(45, firstOver15);
    }

    [Fact]
    public void linqDoesItMatch()
    {
        var numbers = new List<int> { 3, 45, 6, 78, 3, 46, 8, 94 };
        var anyOver100 = numbers.Any(number => number > 100);
        var allOver100 = numbers.All(number => number > 100);
        Assert.Equal(false, anyOver100);
        Assert.Equal(false, allOver100);
    }

    [Fact]
    public void linqFindPerson()
    {
        var persons = new List<Person> { new Person("Aaron"), new Person("Bea"), new Person("Ceasar"), new Person("Dave") };
        var isLongerThan4 = persons
        .Where(person => person.Name.Length > 4)
        .ToList();
        Assert.Equal(2, isLongerThan4.Count);
        Assert.Equal("Aaron", isLongerThan4[0].Name);
    }

    [Fact]
    public void filterPeopleByAgeOnlyNames()
    {
        var people = new List<Person> {
            new Person("Aaron"),
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };

        var allWithLongNames = people
        .Where(p => p.Name.Length > 4)
        .Select(p => p.Name)
        .ToList();

        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaron", allWithLongNames[0]);
        Assert.Equal("Ceasar", allWithLongNames[1]);
    }

    [Fact]
    public void filterPeopleByAgeAndNames()
    {
        var a = new Person("Aaron");
        a.LengthInMeters = 1.96;
        var people = new List<Person> {
            a,
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };

        //act
        var namesAndAges = people
        .Where(p => p.Name.Length > 4)
        .Select(p => new { Name = p.Name, Height = p.LengthInMeters })
        .ToList();

        //assert
        Assert.Equal(2, namesAndAges.Count);
        Assert.Equal("Aaron", namesAndAges[0].Name);
        Assert.Equal(1.96, namesAndAges[0].Height);
    }

    [Fact]
    public void linqOrderBy()
    {
        var numbers = new List<int> { 3, 45, 6, 78, 5, 46, 8, 94 };
        var inOrder = new List<int> { 3, 5, 6, 8, 45, 46, 78, 94 };
        var oppositeOrder = new List<int> { 94, 78, 46, 45, 8, 6, 5, 3 };
        var orderFrom = numbers.OrderBy(number => number);
        var orderDescending = numbers.OrderByDescending(number => number);
        Assert.Equal(inOrder, orderFrom);
        Assert.Equal(oppositeOrder, orderDescending);
    }

    [Fact]
    public void linqQuerySyntax()
    {
        var a = new Person("Aaron");
        a.LengthInMeters = 1.96;
        var people = new List<Person> {
            a,
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };

        //act
        var query =
        from p in people
        where p.Name.Length > 4
        select new { Name = p.Name, Height = p.LengthInMeters };
        var namesAndAges = query.ToList();

        //assert
        Assert.Equal(2, namesAndAges.Count);
        Assert.Equal("Aaron", namesAndAges[0].Name);
        Assert.Equal(1.96, namesAndAges[0].Height);
    }
}