using CHITest.Classes;

namespace CHITest.Numbers;

public class Num4 : CaseType
{
    protected override void Nominative(string gender)
    {
        Add("четыре");
    }

    protected override void Genitive(string gender)
    {
        Add("четырёх");
    }

    protected override void Dative(string gender)
    {
        Add("четырём");
    }

    protected override void Accusative(string gender)
    {
        Add("четыре");
    }

    protected override void Instrumental(string gender)
    {
        Add("четырьмя");
    }

    protected override void Prepositional(string gender)
    {
        Add("четырёх");
    }
}