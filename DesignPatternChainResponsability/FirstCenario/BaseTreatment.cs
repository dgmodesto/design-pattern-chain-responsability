using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternChainResponsability.FirstCenario
{
    public abstract class BaseTreatment
    {
        protected BaseTreatment nextTreatment;

        public BaseTreatment  SetNextTreatment(BaseTreatment treatment)
        {
            this.nextTreatment = treatment;
            return treatment;
        }

        public virtual Call Treat(Call call)
        {
            if (nextTreatment != null)
                return nextTreatment.Treat(call);

            return call;
        }
    }


}
