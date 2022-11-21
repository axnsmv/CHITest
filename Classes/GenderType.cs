namespace CHITest.Classes;

public abstract class GenderType : CaseType
{
    protected GenderType(string gender)
    {
        Gender = gender;
    }

    public string Gender { get; set; }
    public bool Multiple { get; set; }
}