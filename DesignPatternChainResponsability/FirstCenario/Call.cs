using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.FirstCenario
{
    public class Call : BaseTreatment
    {
        public Call(Option option)
        {
            Option = option;
        }

        public Option Option { get; set; }
        public bool Solved { get; set; }
    }
}
