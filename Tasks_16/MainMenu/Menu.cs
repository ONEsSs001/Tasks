using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Channels;
using Tasks_16.FileManager;
using Tasks_16.Models;

namespace Tasks_16.MainMenu
{
    internal class Menu
    {
        private readonly FileMan _fileMan;

        public Menu(FileMan fileman)
        {
            _fileMan = fileman;
        }


        public void ShowMenu()
        {
            string ans = "";
            
           while(ans != "0")
            {
                Console.WriteLine("________________-------Menu------_____________________");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Show All Cars");
                Console.WriteLine("3. Find Car By Name");
                Console.WriteLine("0. Exit");

                ans = Console.ReadLine();

                switch (ans)
                {
                    case "1":
                        AddCar();
                        
                        break;
                    case "2":
                        ShowAll();
                        break;
                    case "3":
                        Console.WriteLine(FindCar());
                        break;
                }
               
            }
        }

        public void AddCar()
        {
            Car car = new();

            Console.WriteLine("Enter Brand");
            car.Brand = Console.ReadLine();
            Console.WriteLine("Enter Model");
            car.Model = Console.ReadLine();
            Console.WriteLine("Enter Year");
            car.Year = Console.ReadLine();
            Console.WriteLine("Enter Price");
            while (true) 
            {
                try
                {
                    car.Price = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter Price");

                }
               
            }
            Console.WriteLine("Enter Color");
            car.Color = Console.ReadLine();

         

            _fileMan.AddCar(car);

            Console.WriteLine("Car Added");


        }

        public void ShowAll()
        {
            foreach (var item in _fileMan.ShowAllCArs())
            {
                Console.WriteLine(item);
            }
        }

        public Car FindCar()
        {
            Console.WriteLine("Enter Brand");
            string brand = Console.ReadLine();
            
            var find = _fileMan.ShowAllCArs().FirstOrDefault(item => item.Brand == brand);
            if(find == null)
            {
                Console.WriteLine("Car Not Found");
                return default;
            }
            return find;
        }

    }
}
