using CHITest.Classes;

namespace CHITest.Numbers;

public class Num1000000000 : GenderType
{
    public Num1000000000(string gender) : base(gender)
    {
    }

    protected override void Nominative(string gender)
    {
        if (Multiple)
            Add("миллиарда");
        else
            Add("миллиард");
    }

    protected override void Genitive(string gender)
    {
        if (Multiple)
            Add("миллиардов");
        else
            Add("миллиарда");
    }

    protected override void Dative(string gender)
    {
        if (Multiple)
            Add("миллиардам");
        else
            Add("миллиарду");
    }

    protected override void Accusative(string gender)
    {
        if (Multiple)
            Add("миллиарда");
        else
            Add("миллиард");
    }

    protected override void Instrumental(string gender)
    {
        if (Multiple)
            Add("миллиардами");
        else
            Add("миллиардом");
    }

    protected override void Prepositional(string gender)
    {
        if (Multiple)
            Add("миллиардах");
        else
            Add("миллиарде");
    }
}