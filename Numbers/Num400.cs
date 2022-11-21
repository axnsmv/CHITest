using CHITest.Classes;

namespace CHITest.Numbers;

public class Num400 : CaseType
{
    protected override void Nominative(string gender)
    {
        Add("четыреста");
    }

    protected override void Genitive(string gender)
    {
        Add("четырёхсот");
    }

    protected override void Dative(string gender)
    {
        Add("четырёхстам");
    }

    protected override void Accusative(string gender)
    {
        Add("четыреста");
    }

    protected override void Instrumental(string gender)
    {
        Add("четырьмястами");
    }

    protected override void Prepositional(string gender)
    {
        Add("четырёхстах");
    }
}