namespace Tools.Converters;

public static class ListConverter
{
    
    public static List<string> ToStringList(this List<char> value)
    {
        return value
            .Select(x => x.ToString())
            .ToList();
    }
}