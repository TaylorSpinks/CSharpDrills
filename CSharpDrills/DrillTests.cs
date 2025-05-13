using Xunit;

namespace CSharpDrills;

public class DrillTests
{
    [Fact]
    public void TestRemoveDuplicates()
    {
        int[] nums = { 1, 3, 2, 1, 3, 5 };

        int[] nonDuplicatedNums = Drills.RemoveDuplicatesAndPreserveOrder(nums);
        
        int[] expected = { 1, 3, 2, 5 };
        
        Assert.Equal(expected, nonDuplicatedNums);
    }

    [Fact]
    public void TestRemoveDuplicatesNextOrder()
    {
        int[] nums = { 4, 2, 2, 4, 3, 1 };

        int[] nonDuplicatedNums = Drills.RemoveDuplicatesAndPreserveOrder(nums);

        int[] expected = { 4, 2, 3, 1 };
        
        Assert.Equal(expected, nonDuplicatedNums);
    }
    
    [Fact]
    public void TestRemoveDuplicatesOrderBreak()
    {
        int[] nums = Enumerable.Range(0, 1000)
            .Select(i => i % 100)
            .ToArray();

        int[] expected = Enumerable.Range(0, 100).ToArray();

        var result = Drills.RemoveDuplicatesAndPreserveOrder(nums);
    
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FrequencyCount()
    {
        int[] nums = { 1, 3, 1, 3, 2, 1 };

        int expectedHighestFrequency = 1;

        int actualHighestFrequency = Drills.GetHighestFrequency(nums);
        
        Assert.Equal(expectedHighestFrequency, actualHighestFrequency);
    }
}