using System;

namespace CSharpPractice
{
    class Zoo
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat("bum", 30);
            Console.WriteLine("Cat Name: " + cat.name + "\n" + "Cat Age: " + cat.age + "\n" + "Cat Jump Distance: " + cat.GetJumpDistance()
                 + "\n" + "Cat Attack Power: " + cat.AttackPower + "\n" + "Cat Climate: " + cat.ClimateValue);

            Employee employee = new Employee
            {
                Name = "Dustin",
                OnVacation = false
            };

            //Example of how ref works
            Console.WriteLine("Before ref: Employee Name: " + employee.Name + "\n" + "Employee On Vacation? " + employee.OnVacation);

            EmployeeGoOnVacation(ref employee);

            Console.WriteLine("After ref: Employee Name: " + employee.Name + "\n" + "Employee On Vacation? " + employee.OnVacation);
        }

        static void EmployeeGoOnVacation(ref Employee employee)
        {
            employee.OnVacation = true;
            employee.Name = "Nitsud";
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public bool OnVacation { get; set; }
    }
}
