using CHITest.Classes;

namespace CHITest.Numbers;

public class Num200 : CaseType
{
    protected override void Nominative(string gender)
    {
        Add("двести");
    }

    protected override void Genitive(string gender)
    {
        Add("двухсот");
    }

    protected override void Dative(string gender)
    {
        Add("двумстам");
    }

    protected override void Accusative(string gender)
    {
        Add("двести");
    }

    protected override void Instrumental(string gender)
    {
        Add("двумястами");
    }

    protected override void Prepositional(string gender)
    {
        Add("двухстах");
    }
}