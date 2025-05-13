using Xunit;

namespace CSharpDrills;

public class DuplicateCheckerStreamTests
{
    
    [Fact]
    public void TestStreamHasDuplicateInWindow()
    {
        int[] stream = { 1,2,3,1};
        int k = 3;

        DuplicateCheckerStream duplicateCheckerStream = new DuplicateCheckerStream(k);

        Assert.False(duplicateCheckerStream.ProcessStream(1));
        Assert.False(duplicateCheckerStream.ProcessStream(2));
        Assert.False(duplicateCheckerStream.ProcessStream(3));
        Assert.True(duplicateCheckerStream.ProcessStream(1));
    }
}