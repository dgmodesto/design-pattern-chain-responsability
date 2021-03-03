using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.FirstCenario
{
    public class SalesTreatment: BaseTreatment
    {
        public override Call Treat(Call call)
        {
            if(call.Option == Option.Sale)
            {
                Console.WriteLine("Sales Treatment");
                call.Solved = true;
                return call;
            }

            return base.Treat(call);
        }
    }
}
