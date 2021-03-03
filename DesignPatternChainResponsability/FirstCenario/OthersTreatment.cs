using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.FirstCenario
{
    class OthersTreatment : BaseTreatment
    {
        public override Call Treat(Call call)
        {
            Console.WriteLine("Another Treatment");
            call.Solved = true;
            return call;
        }
    }
}
