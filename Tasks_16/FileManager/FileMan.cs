using System;
using System.Collections.Generic;
using System.Text;
using Tasks_16.Models;

namespace Tasks_16.FileManager
{
    internal class FileMan
    {
        string CarPath = @"C:\Users\Home\Desktop\spr\Tasks_16\Data\Cars.txt";


        public void AddCar(Car car)
        {
           
            File.AppendAllLines(CarPath, [car.ToString()]);
        }

        public List<Car> ShowAllCArs() 
        {
            
            var cars = File.ReadAllLines(CarPath).ToList();
            
            List<Car> list = new List<Car>();

            foreach (var line in cars)
            {
                var cr = line.Split(',');
                Car car = new();
                car.Brand = cr[0];
                car.Model = cr[1];
                car.Year = cr[2];
                car.Price = decimal.Parse(cr[3]);
                car.Color = cr[4];

                list.Add(car);


            }
            
            return list;

        }


       
    }
}
