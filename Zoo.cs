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

            //Example to showcase how ref functionality works
            Employee refEmployee = new Employee
            {
                Name = "Dustin",
                OnVacation = false
            };

            Console.WriteLine("Before ref: Employee Name: " + refEmployee.Name + "\n" + "Employee On Vacation? " + refEmployee.OnVacation);
            EmployeeRefOnVacation(ref refEmployee);
            Console.WriteLine("After ref: Employee Name: " + refEmployee.Name + "\n" + "Employee On Vacation? " + refEmployee.OnVacation);

            //Example to showcase how out functionality works
            Employee outEmployee = new Employee
            {
                Name = "OutDustin",
                OnVacation = false
            };
            Console.WriteLine("Before out: Employee Name: " + outEmployee.Name + "\n" + "Employee On Vacation ? " + outEmployee.OnVacation);
            EmployeeOutOnVacation(out outEmployee);
            Console.WriteLine("After out: Employee Name: " + outEmployee.Name + "\n" + "Employee On Vacation ? " + outEmployee.OnVacation);

            //Example to showcase how in functionality works
            Employee inEmployee = new Employee
            {
                Name = "OutDustin",
                OnVacation = false
            };
            Console.WriteLine("Before out: Employee Name: " + inEmployee.Name + "\n" + "Employee On Vacation ? " + inEmployee.OnVacation);
            EmployeeInOnVacation(in inEmployee);
            Console.WriteLine("After out: Employee Name: " + inEmployee.Name + "\n" + "Employee On Vacation ? " + inEmployee.OnVacation);
        }

        static void EmployeeRefOnVacation(ref Employee employee)
        {
            //Changes will alter variable outside the method
            employee.OnVacation = true;
            employee.Name = "Nitsud";
        }

        static void EmployeeOutOnVacation(out Employee employee)
        {
            //Must Initialize the parameter when using out
            employee = new Employee();
            employee.OnVacation = true;
        }

        static void EmployeeInOnVacation(in Employee employee)
        {
            //New would throw an Error if used inside an in
            //employee = new Employee();
            employee.Name = "Banana";
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public bool OnVacation { get; set; }
    }
}
