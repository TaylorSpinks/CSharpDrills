using Xunit;

namespace CSharpDrills;

public class DrillTests
{
    [Fact]
    public void TestRemoveDuplicatesTest()
    {
        int[] nums = { 1, 3, 2, 1, 3, 5 };

        int[] nonDuplicatedNums = Drills.RemoveDuplicatesAndPreserveOrder(nums);
        
        int[] expected = { 1, 3, 2, 5 };
        
        Assert.Equal(expected, nonDuplicatedNums);
    }

    [Fact]
    public void TestRemoveDuplicatesNextOrderTest()
    {
        int[] nums = { 4, 2, 2, 4, 3, 1 };

        int[] nonDuplicatedNums = Drills.RemoveDuplicatesAndPreserveOrder(nums);

        int[] expected = { 4, 2, 3, 1 };
        
        Assert.Equal(expected, nonDuplicatedNums);
    }
    
    [Fact]
    public void TestRemoveDuplicatesOrderBreakTest()
    {
        int[] nums = Enumerable.Range(0, 1000)
            .Select(i => i % 100)
            .ToArray();

        int[] expected = Enumerable.Range(0, 100).ToArray();

        var result = Drills.RemoveDuplicatesAndPreserveOrder(nums);
    
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FrequencyCountTest()
    {
        int[] nums = { 1, 3, 1, 3, 2, 1 };

        int expectedHighestFrequency = 1;

        int actualHighestFrequency = Drills.GetHighestFrequency(nums);
        
        Assert.Equal(expectedHighestFrequency, actualHighestFrequency);
    }

    [Fact]
    public void GetTopThreeFrequentElementsTest()
    {
        int[] nums = { 1, 3, 1, 3, 2, 1, 2, 2, 4, 4, 4, 4 };

        int[] expectedTopFrequencies = { 4, 1, 2 };

        int[] actualTopFrequencies = Drills.GetTopThreeMostFrequentNumber(nums);
        
        Assert.Equal(expectedTopFrequencies,actualTopFrequencies);
    }

    [Fact]
    public void GetFrequentNotBannedWord()
    {
        string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
        string[] banned = { "hit" };

        string expectedFrequentNotBannedWord = "ball";

        string actualFrequentNotBannedWord = Drills.GetFrequentNotBannedWord(paragraph, banned);
        
        Assert.Equal(expectedFrequentNotBannedWord,actualFrequentNotBannedWord);
    }
}