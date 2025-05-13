namespace CSharpDrills;

public class StackDrills
{
    public static bool CheckDuplicateBrackets(string expression)
    {
        Stack<char> stackOfChars = new Stack<char>();
        
        foreach (char character in expression)
        {
            stackOfChars.Push(character);
            if (character == ')')
            {
                int popperCount = 0;
                while (stackOfChars.Peek() != '(')
                {
                    stackOfChars.Pop();
                    popperCount++;
                }

                if (popperCount is 0 or 1)
                {
                    return true;
                }
            }
        }

        return false;
    }
}