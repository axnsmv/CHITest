namespace CHITest.Numbers;

public class Num40_7090 : Num5_79
{
    public Num40_7090(string root) : base(root)
    {
    }

    protected override void Nominative(string gender)
    {
        Add(_root);
    }

    protected override void Genitive(string gender)
    {
        Add(_root + "а");
    }

    protected override void Dative(string gender)
    {
        Add(_root + "и");
    }

    protected override void Accusative(string gender)
    {
        Add(_root);
    }

    protected override void Instrumental(string gender)
    {
        Add(_root + "а");
    }

    protected override void Prepositional(string gender)
    {
        Add(_root + "а");
    }
}