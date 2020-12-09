using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Cat : Animal, IWild
    {
        private  int _attackPower = 0;
        private IWild.Climate _climateValue;

        public Cat(string name, int age)
        {
            base.name = name;
            base.age = age;
        }

        public int AttackPower
        {
            get => _attackPower;
            set => _attackPower = value;
        }
        public IWild.Climate ClimateValue 
        {
            get => _climateValue;
            set => _climateValue = IWild.Climate.Jungle;
        }

        public override int GetJumpDistance()
        {
            return age * 2;
        }
    }
}
