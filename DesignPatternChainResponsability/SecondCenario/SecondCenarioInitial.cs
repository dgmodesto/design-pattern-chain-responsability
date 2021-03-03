using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.SecondCenario
{
    public class SecondCenarioInitial
    {
        public static void WithoutPattern()
        {
            var purchase = new Purchase(100);

            if (purchase.Value <= 100)
            {
                Console.WriteLine("Purchase approved by the Manager");
            }
            else if (purchase.Value < 1000)
            {
                Console.WriteLine("Purchase approved by the Director");
            }
            else if (purchase.Value < 100000)
            {
                Console.WriteLine("Purchase approved by the Vice President");
            }
            else if (purchase.Value < 1000000)
            {
                Console.WriteLine("Purchase approved by the President");
            }
            else
            {
                Console.WriteLine("Purchase was not approved");
            }
        }

        public static void WithPattern()
        {
            var action = new ActionSecondCenario();

            action.Approve(1000);
        }
    }
}
