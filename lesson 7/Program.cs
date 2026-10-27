namespace lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("", 3000, "კარდიოლოგი", 50);
            Nurse nurse = new Nurse("ნინო ნინიძე", 1800, "ქირურგია", 15);
            Receptionist receptionist = new Receptionist("ანა ანანიძე", 1500, 100);

            Employee[] employees = { doctor, nurse, receptionist };

            foreach (Employee employee in employees)
            {
                employee.ShowInfo();
                employee.PerformDuty();
                Console.WriteLine("---------------------------");
            }
        }
    }
}
