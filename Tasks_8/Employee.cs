using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_8
{
    internal abstract class Employee
    {

        public string FullName { get; set; }

        private decimal _salary;

        public decimal Salary
        {
            get { return _salary; }
            set 
            {
                if (value < 0 )
                {
                    Console.WriteLine("error");
                }
                else
                {
                    _salary = value;
                }
            }
        }

        bool bonus;
        

        public override string? ToString()
        {
            return $"Name: {FullName}, Salary: {_salary}";
        }

        public abstract void Perform();
        
        
        public abstract decimal Bonus();
       
        
    }
}
