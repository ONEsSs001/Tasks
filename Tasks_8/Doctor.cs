using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_8
{
    internal class Doctor : Employee
    {
        public string Specialization { get; set; }

        private int _patients;

        public int Patients
        {
            get { return _patients; }
            set { _patients = value; }
        }

        decimal bonusPerPatient = 20m;

        public override decimal Bonus()
        {
            return bonusPerPatient * _patients;
        }

        public override void Perform()
        {
            Console.WriteLine("sinjavs pacientebs");
        }
    }
}
