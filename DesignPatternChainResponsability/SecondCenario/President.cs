using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.SecondCenario
{
    class President : DecisionMaker
    {

        public override void Approve(Purchase purchase)
        {
            if (purchase.Value < 1000000)
            {
                Console.WriteLine("Purchase approved by the President");
            }
            else 
            {
                Console.WriteLine("Purchase was not approved");
            }
        }
    }
}