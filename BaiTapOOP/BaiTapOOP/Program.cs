using System;

namespace BaiTapOOP;

class Program
{
    static void Main()
    {
            Console.WriteLine("Nguyễn Tuân Tín 23115053122144");
            Console.WriteLine("Nhân viên parttime");
            IEmployee employee1 = new PartTimeEmployee("Nguyễn Tuan Tín", 45000, 5);
            Console.WriteLine("Name: " + employee1.getName());
            Console.WriteLine("Salary per day: " + employee1.calculateSalary());
            Console.WriteLine("Nhân viên fulltime");
            IEmployee employee2 = new FullTimeEmployee("Linh", 65000);
            Console.WriteLine("Name: " + employee2.getName());
            Console.WriteLine("Salary per day: " + employee2.calculateSalary());
    }
}