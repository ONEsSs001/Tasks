using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_8
{
    internal class Nurse : Employee
    {
        public string Department { get; set; }

        private int bonusPerCvla = 12;
        private int _cvlebi;

        public int Cvlebi
        {
            get { return _cvlebi; }
            set { _cvlebi = value; }
        }

        public override decimal Bonus()
        {
            return _cvlebi * bonusPerCvla;
        }

        public override void Perform()
        {
            Console.WriteLine("exmareba pacientebs");
        }
    }
}
