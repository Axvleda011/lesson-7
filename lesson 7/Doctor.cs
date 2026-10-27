using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_7
{
        class Doctor : Employee
        {
            
            public string Specialization { get; set; }

            
            public int ExaminedPatients { get; set; }

            
            public Doctor(string fullName, decimal salary, string specialization, int examinedPatients)
                : base(fullName, salary)
            {
                Specialization = specialization;
                ExaminedPatients = examinedPatients;
            }

            
            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"სპეციალიზაცია: {Specialization}");
                Console.WriteLine($"გასინჯული პაციენტები: {ExaminedPatients}");
                Console.WriteLine($"ბონუსი: {CalculateBonus()}");
            }

            
            public override void PerformDuty()
            {
                Console.WriteLine($"{FullName} სინჯავს პაციენტებს.");
            }

            
            public override decimal CalculateBonus()
            {
                return ExaminedPatients * 10;
            }
        }
}
