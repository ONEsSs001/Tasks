using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_8
{
    internal class Reger : Employee
    {
        private int _registeredPatients;

        public int RegisteredPatients
        {
            get { return _registeredPatients; }
            set { _registeredPatients = value; }
        }

        int bonusperreg = 5;

        public override decimal Bonus()
        {
            return bonusperreg * _registeredPatients;
        }

        public override void Perform()
        {
            Console.WriteLine("aregistrirebs");
        }
    }
}
