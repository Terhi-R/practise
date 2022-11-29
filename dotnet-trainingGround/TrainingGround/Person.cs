public class Person
{
    public Person()
    {

    }
    public Person(string name)
    {
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
        return current - this.BirthYear;
    }
}