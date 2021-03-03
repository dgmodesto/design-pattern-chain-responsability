using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    class Build : BasePipe
    {
        public override PipelineCustom PlayStep(PipelineCustom pipe)
        {
            Console.WriteLine("Build project");

            return base.PlayStep(pipe);

        }
    }
}
