using System.ComponentModel.Design;

namespace Tasks_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new("Bobby", 91, false);
            Player player2 = new("John", 911, true);
            Player player3 = new("Ludwig", 32, false);
            Player player4 = new("James", 1999, true);
            Player player5 = new("Patrick", 10, false);
            Player player6 = new("Amelia", 897, true);
            Player player7 = new("Lily", 9, true);
            Player player8 = new("Nolan", 85, false);
            Player player9 = new("Melisa", 9, false);
            Player player10 = new("Meruem", 999999999, true);

            List<Player> Players = [player1, player2, player3, player4, player5, player6, player7, player8, player9, player10];

            var sorted = Players.OrderBy(item => item.Point).Reverse();

            Console.WriteLine("Sorted");

            foreach (var item in sorted)
            {
                Console.WriteLine($"Name: {item.Name}, Points: {item.Point}");
            }

            var active = Players.Where(item => item.ActiveStatus);

            Console.WriteLine("Active");
            foreach (var item in active)
            {
                Console.WriteLine($"Name: {item.Name}, Points: {item.Point}");
            }

            Console.WriteLine("Top 1");

            var top1 = Players.MaxBy(item => item.Point);

            Console.WriteLine($"Name: {top1.Name}, Points: {top1.Point}");

            Console.WriteLine("Top 10 Active");

            var top10Active = active.MinBy(item => item.Point);

            Console.WriteLine($"Name: {top10Active.Name}, Points: {top10Active.Point}");
        }
    }
}
