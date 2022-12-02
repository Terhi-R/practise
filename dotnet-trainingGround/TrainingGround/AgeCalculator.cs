namespace TrainingGround;

public enum AgeCategory
{
    Kid,
    Adult,
    Prime
}



public partial class AgeCalculator
{
    public static int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person, int current)
    {
        var age = person.GetAge(current);

        if (age == 50)
        {
            return AgeCategory.Prime;
        }
        else if (age >= 18)
        {
            return AgeCategory.Adult;
        }

        return AgeCategory.Kid;

    }

    public static string GetAgeSpan(AgeCategory category)
    {
        switch (category)
        {
            case AgeCategory.Kid:
                return "You are under 18 years old";
            case AgeCategory.Adult:
                return "You are an adult!";
            case AgeCategory.Prime:
                return "You are at prime age!";
            default:
                return "Unknown";

        }

    }


}
