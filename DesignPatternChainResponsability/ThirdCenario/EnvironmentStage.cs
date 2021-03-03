using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    class EnvironmentStage : BasePipe
    {
        public override PipelineCustom PlayStep(PipelineCustom pipe)
        {
            if (pipe.Environment == Environment.Stage)
            {
                Console.WriteLine("Set Stage Environment");
                EnvironmentFouded = true;
            }

            return base.PlayStep(pipe);

        }
    }
}
