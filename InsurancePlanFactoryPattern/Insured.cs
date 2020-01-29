using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePlanFactoryPattern
{
    abstract class Insured
    {
        public abstract int InsuredAge { get; }
        public abstract string InsurancePlan { get; }
        public abstract decimal InsurancePlanPrice { get; set; }
        public abstract int Appointments { get; set; }
    }
}
