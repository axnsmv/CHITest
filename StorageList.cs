namespace CHITest;

public static class StorageList
{
    private static readonly List<string> Storage = new();

    public static void Add(string part)
    {
        Storage.Add(part);
    }

    public static string Build()
    {
        return string.Join(" ", Storage);
    }
}