using Tasks_16.FileManager;
using Tasks_16.MainMenu;

namespace Tasks_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

             FileMan fileman = new();
            Menu menu = new(fileman);

            menu.ShowMenu();

        }
    }
}
