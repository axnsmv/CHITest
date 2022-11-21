using CHITest.Classes;

namespace CHITest.Numbers;

public class Num300 : CaseType
{
    protected override void Nominative(string gender)
    {
        Add("триста");
    }

    protected override void Genitive(string gender)
    {
        Add("трёхсот");
    }

    protected override void Dative(string gender)
    {
        Add("трёхстам");
    }

    protected override void Accusative(string gender)
    {
        Add("триста");
    }

    protected override void Instrumental(string gender)
    {
        Add("тремястами");
    }

    protected override void Prepositional(string gender)
    {
        Add("трёхстах");
    }
}