using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.FirstCenario
{
    public class RefoundTreatment : BaseTreatment
    {
        public override Call Treat(Call call)
        {
            if (call.Option == Option.Refound)
            {
                Console.WriteLine("Refound Treatment");
                call.Solved = true;
                return call;
            }

            return base.Treat(call);
        }
    }
}
