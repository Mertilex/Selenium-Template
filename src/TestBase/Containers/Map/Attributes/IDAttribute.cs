namespace StepsImplementation.Containers.Map.Attributes;

public class IDAttribute : Attribute
{
    public string ID { get; set; }

    public IDAttribute(string id)
    {
        ID = id;
    }
}