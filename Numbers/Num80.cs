namespace CHITest.Numbers;

public class Num80 : Num50_70
{
    public Num80(string root) : base(root)
    {
    }

    protected override void Nominative(string gender)
    {
        Add("восемьдесят");
    }

    protected override void Accusative(string gender)
    {
        Add("восемьдесят");
    }
}