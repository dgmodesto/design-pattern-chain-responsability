using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    public class EnvironmentDevelopment : BasePipe
    {
        public override PipelineCustom PlayStep(PipelineCustom pipe)
        {
            if (pipe.Environment == Environment.Development)
            {
                Console.WriteLine("Set Develp Environment");
                EnvironmentFouded = true;
            }

            return base.PlayStep(pipe);

        }
    }
}
