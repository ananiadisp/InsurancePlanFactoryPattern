using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePlanFactoryPattern
{
    class ChildInsured : Insured
    {
        private readonly int _age;
        private string _insurancePlan;
        private decimal _insurancePlanPrice;
        private int _appointments;

        public ChildInsured(int age, decimal insurancePlanPrice, int appointments)
        {
            _age = age;
            _insurancePlan = "Child Plan";
            _insurancePlanPrice = insurancePlanPrice;
            _appointments = appointments;
        }

        public override int InsuredAge
        {
            get { return _age; }
        }

        public override string InsurancePlan
        {
            get { return _insurancePlan; }
        }

        public override decimal InsurancePlanPrice
        {
            get { return _insurancePlanPrice; }
            set { _insurancePlanPrice = value; }
        }

        public override int Appointments
        {
            get { return _appointments; }
            set { _appointments = value; }
        }
    }
}
