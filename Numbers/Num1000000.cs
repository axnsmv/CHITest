using CHITest.Classes;

namespace CHITest.Numbers;

public class Num1000000 : GenderType
{
    public Num1000000(string gender) : base(gender)
    {
    }

    protected override void Nominative(string gender)
    {
        if (Multiple)
            Add("миллиона");
        else
            Add("миллион");
    }

    protected override void Genitive(string gender)
    {
        if (Multiple)
            Add("миллионов");
        else
            Add("миллиона");
    }

    protected override void Dative(string gender)
    {
        if (Multiple)
            Add("миллионам");
        else
            Add("миллиону");
    }

    protected override void Accusative(string gender)
    {
        if (Multiple)
            Add("миллиона");
        else
            Add("миллион");
    }

    protected override void Instrumental(string gender)
    {
        if (Multiple)
            Add("миллионами");
        else
            Add("миллионом");
    }

    protected override void Prepositional(string gender)
    {
        if (Multiple)
            Add("миллионах");
        else
            Add("миллионе");
    }
}