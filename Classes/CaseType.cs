namespace CHITest.Classes;

public abstract class CaseType
{
    protected void Add(string s)
    {
        StorageList.Add(s);
    }

    public void BuildString(string sGender, string sCase)
    {
        sGender = sGender.ToLower();
        switch (sCase.ToLower())
        {
            case "и":
                Nominative(sGender);
                break;
            case "р":
                Genitive(sGender);
                break;
            case "д":
                Dative(sGender);
                break;
            case "в":
                Accusative(sGender);
                break;
            case "т":
                Instrumental(sGender);
                break;
            case "п":
                Prepositional(sGender);
                break;
            default:
                throw new Exception("Unsupported case");
        }
    }

    protected abstract void Nominative(string gender);
    protected abstract void Genitive(string gender);
    protected abstract void Dative(string gender);
    protected abstract void Accusative(string gender);
    protected abstract void Instrumental(string gender);
    protected abstract void Prepositional(string gender);
}