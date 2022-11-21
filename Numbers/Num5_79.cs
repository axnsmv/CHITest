using CHITest.Classes;

namespace CHITest.Numbers;

public class Num5_79 : CaseType
{
    protected string _root;

    public Num5_79(string root)
    {
        _root = root;
    }

    protected override void Nominative(string gender)
    {
        Add(_root + "ь");
    }

    protected override void Genitive(string gender)
    {
        Add(_root + "и");
    }

    protected override void Dative(string gender)
    {
        Add(_root + "и");
    }

    protected override void Accusative(string gender)
    {
        Add(_root + "ь");
    }

    protected override void Instrumental(string gender)
    {
        Add(_root + "ью");
    }

    protected override void Prepositional(string gender)
    {
        Add(_root + "и");
    }
}