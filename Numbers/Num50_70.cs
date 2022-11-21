namespace CHITest.Numbers;

public class Num50_70 : Num5_79
{
    public Num50_70(string root) : base(root)
    {
    }

    protected override void Nominative(string gender)
    {
        Add(_root + "ьдесят");
    }

    protected override void Genitive(string gender)
    {
        Add(_root + "идесяти");
    }

    protected override void Dative(string gender)
    {
        Add(_root + "идесяти");
    }

    protected override void Accusative(string gender)
    {
        Add(_root + "ьдесят");
    }

    protected override void Instrumental(string gender)
    {
        Add(_root + "ьюдесятью");
    }

    protected override void Prepositional(string gender)
    {
        Add(_root + "идесяти");
    }
}