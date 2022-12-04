namespace TrainingGround;


public class Person : IPrintable
{
    public Person()
    {

    }
    public Person(string name)
    {
        this.Name = name;
    }

    public Person(string name, string id)
    {
        this.EmployeeId = id;
        this.Name = name;
    }

    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }

    private string? _name;
    public string? Name
    {
        get; private set;
    }

    private int _birthYear;
    public int BirthYear { get { return _birthYear; } private set { this._birthYear = value; } }


    public double LengthInMeters;

    public int GetAge(int born, int current)
    {
        return current - born;
    }

    public int GetAge(int current)
    {
        var age = current - this.BirthYear;
        if (age < 0)
        {
            throw new Exception("Not born yet");
        }
        return age;
    }

    public Address Address { get; set; }

    public string EmployeeId { get; set; }

    public string GetPrintString()
    {
        return @$"{this.Name} ({this.EmployeeId}) 
        {this.Address.Street} {this.Address.StreetNo}
        {this.Address.City}";
    }
}