using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.FirstCenario
{
    public class ActionFirstCenario
    {
        public void Treat(Option option)
        {
            BaseTreatment treat = new SalesTreatment();
            treat
                .SetNextTreatment(new RefoundTreatment())
                .SetNextTreatment(new OthersTreatment());

            treat.Treat(new Call(option));
        }
    }
}
