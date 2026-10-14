namespace Tasks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //111111111111111111111111111111111111111111111111111111111111111111111111111111111111111


            Movie movie = new();

            movie.Name = "Frankenstein";
            movie.ReleaseDate = "September 8, 2025 (Canada)";
            movie.Genre = "Gothic novel, Science Fiction";
            movie.Runtime = 150;
            movie.Rates = [3, 5, 4, 3, 4, 5, 5, 5];

            movie.ShowInfo();
            movie.ShowRate();
            movie.FormatRuntime();
        }
    }
}
