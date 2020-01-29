using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePlanFactoryPattern.FactoryPattern
{
    abstract class InsuredFactory
    {
        public abstract Insured GetInsured();
    }
}
