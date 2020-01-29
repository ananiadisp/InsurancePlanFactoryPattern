using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePlanFactoryPattern.FactoryPattern
{
    class ChildInsuredFactory : InsuredFactory
    {
        private int _age;
        private decimal _insurancePlanPrice;
        private int _appointments;

        public ChildInsuredFactory(int age, decimal InsurancePlanPrice, int appointments)
        {
            _age = age;
            _insurancePlanPrice = InsurancePlanPrice;
            _appointments = appointments;
        }

        public override Insured GetInsured()
        {
            return new ChildInsured(_age, _insurancePlanPrice, _appointments);
        }
    }
}
