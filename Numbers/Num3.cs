using CHITest.Classes;

namespace CHITest.Numbers;

public class Num3 : CaseType
{
    protected override void Nominative(string gender)
    {
        Add("три");
    }

    protected override void Genitive(string gender)
    {
        Add("трёх");
    }

    protected override void Dative(string gender)
    {
        Add("трём");
    }

    protected override void Accusative(string gender)
    {
        Add("три");
    }

    protected override void Instrumental(string gender)
    {
        Add("тремя");
    }

    protected override void Prepositional(string gender)
    {
        Add("трёх");
    }
}