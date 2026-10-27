using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_7
{
    internal class Receptionist: Employee
    {
        public int RegisteredPatients { get; set; }

        public Receptionist(string fullName, decimal salary, int registeredPatients)
            : base(fullName, salary)
        {
            RegisteredPatients = registeredPatients;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"რეგისტრირებული პაციენტები: {RegisteredPatients}");
            Console.WriteLine($"ბონუსი: {CalculateBonus()}");
        }

        public override void PerformDuty()
        {
            Console.WriteLine($"{FullName} არეგისტრირებს პაციენტებს.");
        }

        
        public override decimal CalculateBonus()
        {
            return RegisteredPatients * 5;
        }
    }
}
