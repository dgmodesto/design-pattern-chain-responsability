namespace DesignPatternChainResponsability.ThirdCenario
{
    public class PipelineCustom
    {
        public PipelineCustom(Environment environment)
        {
            Environment = environment;
        }

        public  Environment Environment { get; private set; }


    }
}