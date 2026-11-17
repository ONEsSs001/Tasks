using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

namespace Tasks_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = ["John", "Joseph", "Jonathan"];


            Dictionary<string, int> dict = [];

            dict.Add("John", 900);
            dict.Add("Joseph", 1200);
            dict.Add("Jonathan", 7771);


            while (true)
            {
                Console.WriteLine("_________--------Menu--------___________");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Find");
                Console.WriteLine("3. Show all");

                int ans = 0;
                int score = 0;
                try
                {
                    ans = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Error");
                }

                switch (ans)
                {
                    case 0:


                        break;

                    case 1:

                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Score");
                        try
                        {
                            score = int.Parse(Console.ReadLine());

                            if (!dict.ContainsKey(name))
                            {
                                dict.Add(name, score);
                                list.Add(name);
                                Console.WriteLine("User Added");
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Errorrrrrrrrrrrr Enter Number");
                        }

                       

                        break;

                    case 2:

                        Console.WriteLine("Enter Name");
                        string nam = Console.ReadLine();

                        if (dict.ContainsKey(nam))
                        {
                            Console.WriteLine($"Name: {nam}, Score {dict[nam]}");
                        }
                        else
                        {
                            Console.WriteLine("User not Found");
                        }
                        break;

                    case 3:
                        foreach (var i in dict)
                        {
                            Console.WriteLine($" Name: {i.Key} - Score: {i.Value}");
                        }
                        break;
                }
            }

        }
    }
}
