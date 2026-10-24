namespace Tasks_9
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Array arr = new();

            arr.ShowEven(arr.array);
            arr.ShowOdd(arr.array);
            Console.WriteLine(arr.CountDistinct(arr.array));
            Console.WriteLine(arr.EqualToValue(3, arr.array));
        }
    }
}
