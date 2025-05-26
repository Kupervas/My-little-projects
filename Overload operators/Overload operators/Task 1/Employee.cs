using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_operators.Task_1
{
    public class Employee
    {
        public decimal Salary { get; set; }
        public Employee(decimal salary)
        {
            Salary = salary;
        }
        public static Employee operator +(Employee emp, decimal amount)
        {
            return new Employee(emp.Salary + amount);
        }
        public static Employee operator -(Employee emp, decimal amount)
        {
            return new Employee(emp.Salary - amount);
        }
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2)) return true;
            if (emp1 is null || emp2 is null) return false;
            return emp1.Salary == emp2.Salary;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Salary < emp2.Salary;
        }
        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.Salary > emp2.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
                return this == emp;
            return false;
        }
        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
    }
}