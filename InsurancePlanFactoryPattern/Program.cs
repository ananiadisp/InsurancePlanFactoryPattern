using InsurancePlanFactoryPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePlanFactoryPattern
{
    class Program
    {
        public static int AgeInput()
        {
            Console.Write("Please enter your age to inform you about the proposed insurance Plan: ");
            var ageInput = Console.ReadLine();
            double age;
            if (!double.TryParse(ageInput, out age))
            {
                Console.Clear();
                Console.WriteLine("Age should be a Number!");
                age = AgeInput();
            }
            return Convert.ToInt32(Math.Round(age, 0, MidpointRounding.ToEven));
        }
        static void Main(string[] args)
        {
            InsuredFactory factory = null;
            int age = AgeInput();
            
            do
            {
                if (age < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Age cannot be a negative number");
                    age = AgeInput();
                }
                else if (age > 85)
                {
                    Console.Clear();
                    Console.WriteLine("There are not any available Insurance Plans for above 85 years old ");
                    age = AgeInput();
                }
                else if (age >= 0 && age <=12)
                {
                    factory = new ChildInsuredFactory(age, 100, 60);
                }
                else if (age > 12 && age <= 18)
                {
                    factory = new AdolescenceInsuredFactory(age, 200, 70);
                }
                else if (age > 18 && age <= 59)
                {
                    factory = new AdultInsuredFactory(age, 300, 80);
                }
                else
                {
                    factory = new SeniorAdultInsuredFactory(age, 400, 100);
                }
            } while (age < 0 && age >= 85);

            Insured insured = factory.GetInsured();

            Console.Clear();
            Console.WriteLine("You should subscribed for th below Insurance Plan");
            Console.WriteLine($"Insurance Plan: {insured.InsurancePlan}");
            Console.WriteLine($"Insurance Plan Cost: {insured.InsurancePlanPrice}");
            Console.WriteLine($"Insurance Plan Appointments: {insured.Appointments}");
            Console.ReadKey();

        }
    }
}
