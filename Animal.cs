using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    abstract class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        public abstract int GetJumpDistance();
    }
}
