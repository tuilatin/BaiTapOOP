using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP
{
    class FullTimeEmployee : Employee
    {

        public FullTimeEmployee()
        {
        }

        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return this.paymentPerHour * 8;
        }

        public override string getName()
        {
            return this.name;
        }

    }
}
