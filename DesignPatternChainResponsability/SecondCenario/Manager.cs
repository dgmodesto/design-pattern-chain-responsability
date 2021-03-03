using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.SecondCenario
{
    public class Manager : DecisionMaker
    {

        public override void Approve(Purchase purchase)
        {
            if(purchase.Value < 1000)
            {
                Console.WriteLine("Purchase approved by the Manger");
            } else if(Sucessor != null)
            {
                Sucessor.Approve(purchase);
            }
        }
    }
}
