using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Zoo
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat("bum", 30);
            Console.WriteLine("Cat Name: " + cat.name);
            Console.WriteLine("Cat Age : " + cat.age);
            Console.WriteLine("Cat Jump Distance: " + cat.GetJumpDistance());
            Console.WriteLine("Cat Attack Power: " + cat.AttackPower);
            Console.WriteLine("Cat Climate: " + cat.ClimateValue);
        }
    }
}
