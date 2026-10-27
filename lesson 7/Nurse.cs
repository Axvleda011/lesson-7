using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_7
{
    internal class Nurse: Employee
    {
        public string Department { get; set; }

        
        public int CompletedShifts { get; set; }

        
        public Nurse(string fullName, decimal salary, string department, int completedShifts)
            : base(fullName, salary)
        {
            Department = department;
            CompletedShifts = completedShifts;
        }

        
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"განყოფილება: {Department}");
            Console.WriteLine($"შესრულებული ცვლები: {CompletedShifts}");
            Console.WriteLine($"ბონუსი: {CalculateBonus()}");
        }

        
        public override void PerformDuty()
        {
            Console.WriteLine($"{FullName} ეხმარება პაციენტებს.");
        }

        
        public override decimal CalculateBonus()
        {
            return CompletedShifts * 20;
        }
    }
}
