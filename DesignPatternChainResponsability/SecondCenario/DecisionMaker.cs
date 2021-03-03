using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.SecondCenario
{
    // Handler
    public abstract class DecisionMaker
    {
        protected DecisionMaker Sucessor;

        public DecisionMaker SetSucessor(DecisionMaker sucessor)
        {
            this.Sucessor = sucessor;
            return this.Sucessor;
        }

        public abstract void Approve(Purchase purchase);
    }
}
