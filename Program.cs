using DSA.DSA.Algorithm.Sort;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("");

        Console.WriteLine("SelectionSort Result:");
        Sort.SelectionSort([13, 46, 24, 52, 20, 9]);
        Console.WriteLine("");

        Console.WriteLine("BubbleSort Result:");
        Sort.BubbleSort([13, 46, 24, 52, 20, 9]);
        Console.WriteLine("");

        Console.WriteLine("InsertionSort Result:");
        Sort.InsertionSort([13, 46, 24, 52, 20, 9]);
        Console.WriteLine("");
    }
}