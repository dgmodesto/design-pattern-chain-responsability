using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    public class Test : BasePipe
    {
        public override PipelineCustom PlayStep(PipelineCustom pipe)
        {
            Console.WriteLine("Test Project");
            return base.PlayStep(pipe);

        }
    }
}
