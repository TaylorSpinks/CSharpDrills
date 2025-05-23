namespace CSharpDrills;

public class Drills
{
    // not guaranteed, although I couldn't break in my tests
    public static int[] RemoveDuplicatesAndPreserveOrder(int[] arrayWithDuplicates)
    {
        HashSet<int> duplicates = new HashSet<int>(arrayWithDuplicates);
        return duplicates.ToArray();
    }

    // better
    public static int[] RemoveDuplicatesAndPreserveOrderV2(int[] arrayWithDuplicates)
    {
        var seen = new HashSet<int>();
        var result = new List<int>();

        foreach (int num in arrayWithDuplicates)
        {
            if (seen.Add(num))
            {
                result.Add(num);
            }
        }

        return result.ToArray();
    }

    public static int GetHighestFrequency(int[] nums)
    {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (frequencies.ContainsKey(num))
            {
                frequencies[num]++;
            }
            else
            {
                frequencies.Add(num, 1);
            }
        }

        return frequencies.OrderByDescending(kvp => kvp.Value).First().Key;
    }

    public static int[] GetTopThreeMostFrequentNumber(int[] nums)
    {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (frequencies.ContainsKey(num))
            {
                frequencies[num]++;
            }
            else
            {
                frequencies.Add(num, 1);
            }
        }

        return frequencies.OrderByDescending(kvp => kvp.Value)
            .Take(3)
            .Select(pair => pair.Key)
            .ToArray();
    }

    public static string GetFrequentNotBannedWord(string paragraph, string[] banned)
    {
        Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();
        string[] cleanedParagraph = paragraph
            .ToLower()
            .Split(' ')
            .Where(word => !banned.Contains(word.ToLower()))
            .Select(word => word.Trim(',', '.', '!', '?', '\'', '\"'))
            .ToArray();
        
        foreach (var word in cleanedParagraph)
        {
            if (wordFrequencies.ContainsKey(word))
            {
                wordFrequencies[word]++;
            }
            else
            {
                wordFrequencies.Add(word,1);
            }
        }

        return wordFrequencies.OrderByDescending(kvp => kvp.Value).First().Key.ToString();
    }
    
    // faster
    public static string GetFrequentNotBannedWordV2(string paragraph, string[] banned)
    {
        HashSet<string> bannedHashSet = new HashSet<string>(banned);
        
        Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();
        string[] cleanedParagraph = paragraph
            .ToLower()
            .Split(' ')
            .Where(word => !bannedHashSet.Contains(word.ToLower()))
            .Select(word => word.Trim(',', '.', '!', '?', '\'', '\"'))
            .ToArray();
        
        foreach (var word in cleanedParagraph)
        {
            if (wordFrequencies.ContainsKey(word))
            {
                wordFrequencies[word]++;
            }
            else
            {
                wordFrequencies.Add(word,1);
            }
        }

        return wordFrequencies.OrderByDescending(kvp => kvp.Value).First().Key.ToString();
    }
    
}