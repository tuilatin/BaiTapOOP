using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP
{
    class Employee : IEmployee
    {
        protected string name { get; set;}
        protected int paymentPerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public virtual int calculateSalary()
        {
            throw new NotImplementedException();
        }

        public virtual string getName()
        {
            throw new NotImplementedException();
        }
    }
}
