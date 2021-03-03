using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.SecondCenario
{
    public class Purchase
    {
        private double value;

        public Purchase(double value)
        {
            Value = value;
        }

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

    }
}
