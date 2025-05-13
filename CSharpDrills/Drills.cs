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


    public static int GetHighestFrequency()
    {
        throw new NotImplementedException();
    }
}