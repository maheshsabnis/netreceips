using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EFCore_CodeFIrst.Models
{

	public class Doctor
	{
		[Key]
		public int DoctorId { get; set; }
		public string DoctorName { get; set; }
		public ICollection<Patient> Patients { get; set; } // Expected Many-to-Many
	}

	public class Patient
	{
		[Key]
		public int PatientId { get; set; }
		public string PatientName { get; set; }
		public ICollection<Doctor> Doctors { get; set; }// Expected Many-to-Many
	}
}
