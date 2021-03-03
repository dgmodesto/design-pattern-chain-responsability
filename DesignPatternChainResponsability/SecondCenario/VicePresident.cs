using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.SecondCenario
{
    public class VicePresident : DecisionMaker
    {

        public override void Approve(Purchase purchase)
        {
            if (purchase.Value < 100000)
            {
                Console.WriteLine("Purchase approved by the Vice President");
            }
            else if (Sucessor != null)
            {
                Sucessor.Approve(purchase);
            }
        }
    }
}
