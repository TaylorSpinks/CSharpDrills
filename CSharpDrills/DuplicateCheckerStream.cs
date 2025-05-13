namespace CSharpDrills;

public class DuplicateCheckerStream
{
    private Queue<int> _duplicateQueue = new ();
    private int _k = new int();

    public DuplicateCheckerStream(int k)
    {
        _k = k;
    }

    public bool ProcessStream(int integerToEnqueue)
    {
        if (_duplicateQueue.Contains(integerToEnqueue))
            return true;

        if (_duplicateQueue.Count == _k)
            _duplicateQueue.Dequeue();
        
        _duplicateQueue.Enqueue(integerToEnqueue);

        return false;
    }
        
}