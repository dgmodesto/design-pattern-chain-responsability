using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    public abstract class BasePipe
    {
        protected BasePipe nextStep;
        protected static bool EnvironmentFouded;
        public BasePipe SetNextStep(BasePipe nextStep)
        {
            this.nextStep = nextStep;
            return this.nextStep;
        }

        public virtual PipelineCustom PlayStep(PipelineCustom pipelineCustom)
        {
            if (nextStep != null)
                return nextStep.PlayStep(pipelineCustom);

            return pipelineCustom;
        }

    }
}
