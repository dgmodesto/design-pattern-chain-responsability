using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.ThirdCenario
{
    public class ThirdCenarioInitial
    {
        public static void WithoutPattern()
        {
            var option = Environment.Development;

            switch(option)
            {
                case Environment.Development:
                    Console.WriteLine("Environment Development");
                    break;
                case Environment.Stage:
                    Console.WriteLine("Environment Stage");
                    break;
                case Environment.Production:
                    Console.WriteLine("Environment Development");
                    break;
                default:
                    Console.WriteLine("Environment not found");
                    return;
            }

            Console.WriteLine("build project");
            Console.WriteLine("test project");
            Console.WriteLine("docker image");



        }

        public static void WithPattern()
        {
            var action = new ActionThirdCenario();
            action.StartPipeline(Environment.Stage);
        }
    }
}
