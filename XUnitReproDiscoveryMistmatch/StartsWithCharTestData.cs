using Xunit;
namespace XUnitReproDiscoveryMistmatch;

internal class StartsWithCharTestData : TheoryData<string, char, bool>
{
    public StartsWithCharTestData()
    {
        Add("apple", 'a', true);
        Add("banana", 'b', true);
    }
}
