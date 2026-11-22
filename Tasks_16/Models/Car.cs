using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_16.Models
{
    internal class Car
    {
       

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

        public override string? ToString()
        {
            return $"{Brand},{Model},{Year},{Price},{Color}";
        }
    }
}
