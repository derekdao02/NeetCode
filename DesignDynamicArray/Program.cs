internal class Program
{
    private static void Main(string[] args)
    {
        DynamicArray dynamicArray = new DynamicArray(5);

        dynamicArray.PushBack(2);
        Console.Write($"Size of array: {dynamicArray.GetSize()}");
    }
}
