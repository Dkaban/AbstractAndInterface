using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    interface IWild
    {
        public int AttackPower { get; set; }
        public enum Climate
        {
            Tropical,
            Jungle,
            Forest,
            Snow
        }

        public Climate ClimateValue { get; set; }
    }
}
