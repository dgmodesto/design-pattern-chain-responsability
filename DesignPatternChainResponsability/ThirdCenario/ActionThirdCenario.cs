using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    public class ActionThirdCenario
    {
        public void StartPipeline(Environment environment)
        {
            BasePipe pipe = new EnvironmentDevelopment();

            pipe
                //.SetNextStep(new EnvironmentStage())
                .SetNextStep(new EnvironmentProduction())
                .SetNextStep(new Build())
                .SetNextStep(new Test())
                .SetNextStep(new Docker());


            pipe.PlayStep(new PipelineCustom(environment));
        }
    }
}
