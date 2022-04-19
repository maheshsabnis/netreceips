
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPsApp.Models
{
    /// <summary>
    /// Data Class to Store Employee Information
    /// </summary>
    internal class Employee
    {
        private int _EmpNo;
        public int EmpNo
        {
            get { return _EmpNo; } // read
            set { _EmpNo = value; } // write
        }
        private string _EmpName;
        public string EmpName
        {
            get { return _EmpName; } // return value
            set { _EmpName = value; } // accept value
        }
        private string _DeptName;
        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }
        private string _Designation;
        public string Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }
        private int _Salary;
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
    }
}
