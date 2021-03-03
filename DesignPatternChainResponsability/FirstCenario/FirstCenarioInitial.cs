using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.FirstCenario
{
    public static class FirstCenarioInitial
    {
        public static void WithoutPattern()
        {
            var option = Option.Refound;

            if (option == Option.Sale)
            {
                Console.WriteLine("Sale Treatment");
            }
            else if (option == Option.Refound)
            {
                Console.WriteLine("Refound Treatment");
            }
            else
            {
                Console.WriteLine("Another Treatment");
            }
        }

        public static void WithPattern()
        {
            var action = new ActionFirstCenario();

            action.Treat(Option.Refound);
        }
    }
}
