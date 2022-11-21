namespace CHITest.Numbers;

public class Num500_700900 : Num5_79
{
    public Num500_700900(string root) : base(root)
    {
    }

    protected override void Nominative(string gender)
    {
        Add(_root + "ьсот");
    }

    protected override void Genitive(string gender)
    {
        Add(_root + "исот");
    }

    protected override void Dative(string gender)
    {
        Add(_root + "истам");
    }

    protected override void Accusative(string gender)
    {
        Add(_root + "ьсот");
    }

    protected override void Instrumental(string gender)
    {
        Add(_root + "ьюстами");
    }

    protected override void Prepositional(string gender)
    {
        Add(_root + "истах");
    }
}