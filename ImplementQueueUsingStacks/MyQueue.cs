class MyQueue
{
    private Stack<int> _stackIn;
    private Stack<int> _stackOut;

    public MyQueue()
    {
        _stackIn = new Stack<int>();
        _stackOut = new Stack<int>();
    }

    public void Push(int x)
    {
        _stackIn.Push(x);
    }

    public int Pop()
    {
        ConvertStackToQueu();

        return _stackOut.Pop();
    }

    public int Peek()
    {
        ConvertStackToQueu();

        return _stackOut.Peek();
    }

    public bool Empty()
    {
        ConvertStackToQueu();

        return !_stackOut.Any();
    }

    private void ConvertStackToQueu()
    {
        if (!_stackOut.Any())
            while (_stackIn.Any())
                _stackOut.Push(_stackIn.Pop());
    }
}
