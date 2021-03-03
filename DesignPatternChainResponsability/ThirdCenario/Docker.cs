using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    public class Docker : BasePipe
    {
        public override PipelineCustom PlayStep(PipelineCustom pipe)
        {
            Console.WriteLine("docker image");
            return pipe;
        }
    }
}
