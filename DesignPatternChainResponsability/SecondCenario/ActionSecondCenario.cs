using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.SecondCenario
{
    public class ActionSecondCenario
    {
        // Make decision
        public void Approve(double value)
        {
            DecisionMaker dm = new Manager();
            dm
                .SetSucessor(new Director())
                .SetSucessor(new VicePresident())
                .SetSucessor(new President());

            dm.Approve(new Purchase(value));
        }
    }
}
