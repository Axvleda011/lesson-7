using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_7
{
        internal class Employee
        {
            
            public string FullName { get; set; }

            
            private decimal salary;

            
            public decimal Salary
            {
                get { return salary; }
                set
                {
                    if (value >= 0)
                        salary = value;
                    else
                        Console.WriteLine("ხელფასი არ შეიძლება იყოს უარყოფითი!");
                }
            }

            
            public Employee(string fullName, decimal salary)
            {
                FullName = fullName;
                Salary = salary;
            }

            
            public virtual void ShowInfo()
            {
                Console.WriteLine($"სახელი და გვარი: {FullName}");
                Console.WriteLine($"ხელფასი: {Salary}");
            }

            
            public virtual void PerformDuty()
            {
                Console.WriteLine("თანამშრომელი ასრულებს თავის მოვალეობას.");
            }

            public virtual decimal CalculateBonus()
            {
                return 0;
            }
        }
    
}
