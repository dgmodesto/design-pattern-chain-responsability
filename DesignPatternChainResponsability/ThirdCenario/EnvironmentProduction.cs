using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    class EnvironmentProduction : BasePipe
    {
        public override PipelineCustom PlayStep(PipelineCustom pipe)
        {
            if (pipe.Environment == Environment.Production)
            {
                Console.WriteLine("Set Procution Environment");
            } else if(!EnvironmentFouded)
            {
                Console.WriteLine("Environment Not Found");
                return null;
            }

            return base.PlayStep(pipe);

        }
    }
}
