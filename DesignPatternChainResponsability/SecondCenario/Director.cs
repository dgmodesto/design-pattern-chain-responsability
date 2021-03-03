using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.SecondCenario
{
    public class Director : DecisionMaker
    {

        public override void Approve(Purchase purchase)
        {
            if (purchase.Value < 10000)
            {
                Console.WriteLine("Purchase approved by the Director");
            }
            else if (Sucessor != null)
            {
                Sucessor.Approve(purchase);
            }
        }
    }
}
