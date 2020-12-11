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

            DisplayResultToUser("Initial values: ", employee);

            //Show what Ref is doing to the employee object
            RefExample(ref employee);
            DisplayResultToUser("after ref: ", employee);

            //Show what Out is doing to the employee object
            OutExample(out employee);
            DisplayResultToUser("after out: ", employee);

            //Show what In is doing to the employee object
            InExample(in employee);
            DisplayResultToUser("after in: ", employee);
        }

        static void DisplayResultToUser(String prefix, Employee employee)
        {
            Console.WriteLine(prefix + ": Employee Name: " + employee.Name + "\n" + "Employee On Vacation? " + employee.OnVacation);
        }

        static void RefExample(ref Employee employee)
        {
            //Changes will alter variable outside the method
            employee.OnVacation = true;
            employee.Name = "Nitsud";
        }

        static void OutExample(out Employee employee)
        {
            //Must Initialize the parameter when using out
            employee = new Employee();
            //Name will be empty as we never initialized it
            employee.OnVacation = false;
        }

        static void InExample(in Employee employee)
        {
            //New would throw an Error if used inside an in
            //employee = new Employee();
            employee.Name = "Banana";
        }
    }
}
