using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance
{
    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string MobineNo { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
    }

    /// <summary>
    /// FullTime is Derived from Employee Base class
    /// </summary>
    internal class FullTime : Employee
    {
        public string DeptName { get; set; }
        public int BasicSalary { get; set; }
        public int HRA { get; set; }
        public int TA { get; set; }
        public int DA { get; set; }
        public int GrossSalary { get; set; }
        public int NetSalary { get; set; }
        public int Tax { get; set; }
    }

    internal class Manager : FullTime
    {
        public int TravelAllowance { get; set; }
        public int PetrolAllowance { get; set; }
    }

    internal class Engineer : FullTime
    {
        public int OverTimeHours { get; set; }
        public int OverTimeRatesPerHour { get; set; }
    }
    internal class Consultant : Employee
    {
        public int ConsultationFees { get; set; }
        public int MandatoryWorkingHours { get; set; }
        public int AdditionalWorkingHours { get; set; }
        public int AdditionRatePerHour { get; set; }
    }
}
