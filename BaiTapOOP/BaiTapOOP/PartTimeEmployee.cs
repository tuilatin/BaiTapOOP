using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP
{
    class PartTimeEmployee : Employee
    {
        private int workingHours { get; set; }

        public PartTimeEmployee()
        {
        }
        public PartTimeEmployee(String name, int paymentPerHour, int workingHours) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }
        public override int calculateSalary()
        {
            return this.paymentPerHour * this.workingHours;
        }

        public override string getName()
        {
            return this.name;
        }
    }
}
