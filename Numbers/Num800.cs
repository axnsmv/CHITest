namespace CHITest.Numbers;

public class Num800 : Num500_700900
{
    public Num800(string root) : base(root)
    {
    }

    protected override void Nominative(string gender)
    {
        Add("восемьсот");
    }

    protected override void Accusative(string gender)
    {
        Add("восемьсот");
    }

    protected override void Instrumental(string gender)
    {
        Add("восемьюстами");
    }
}