internal class Program
{
    private static void Main(string[] args)
    {
        MyQueue myQueue = new MyQueue();
        myQueue.Push(1);
        myQueue.Push(2);

        Console.WriteLine($"Peek: {myQueue.Peek()}");
        Console.WriteLine($"Pop: {myQueue.Pop()}");
        Console.WriteLine($"Empty: {myQueue.Empty()}");
    }
}
