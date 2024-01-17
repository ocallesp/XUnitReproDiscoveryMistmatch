namespace XUnitReproDiscoveryMistmatch;

internal class MyDescriptorClass : TheoryData<string, MyDescriptor>
{
    public MyDescriptorClass()
    {
        AddWithHashsets("Name1", new MyDescriptor());

        AddWithHashsets("Name2", new MyDescriptor());
    }

    private void AddWithHashsets(
     string recipeFile,
     MyDescriptor app)
    {
        this.Add(recipeFile, app);
    }
}

public class MyDescriptor
{
    public string Property1 { get; set; }

    public int Property2 { get; set; }
}