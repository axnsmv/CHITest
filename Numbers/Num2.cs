using CHITest.Classes;

namespace CHITest.Numbers;

public class Num2 : CaseType
{
    protected override void Nominative(string gender)
    {
        switch (gender)
        {
            case "c":
            case "м":
                Add("два");
                break;
            case "ж":
                Add("две");
                break;
        }
    }

    protected override void Genitive(string gender)
    {
        Add("двух");
    }

    protected override void Dative(string gender)
    {
        Add("двум");
    }

    protected override void Accusative(string gender)
    {
        switch (gender)
        {
            case "c":
            case "м":
                Add("два");
                break;
            case "ж":
                Add("две");
                break;
        }
    }

    protected override void Instrumental(string gender)
    {
        Add("двумя");
    }


    protected override void Prepositional(string gender)
    {
        Add("двух");
    }
}