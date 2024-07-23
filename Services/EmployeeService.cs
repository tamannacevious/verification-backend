using System.Collections.Generic;
using System.Linq;

namespace EmploymentVerification
{
    public interface IEmployeeService
    {
        bool VerifyEmployment(int employeeId, string companyName, string verificationCode);
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees;

        public EmployeeService()
        {
            // Prepopulate with sample data
            _employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, CompanyName = "ABC Corp", VerificationCode = "ABC123" },
                new Employee { EmployeeId = 2, CompanyName = "XYZ Ltd", VerificationCode = "XYZ789" }
            };
        }

        public bool VerifyEmployment(int employeeId, string companyName, string verificationCode)
        {
            return _employees.Any(e => e.EmployeeId == employeeId && e.CompanyName == companyName && e.VerificationCode == verificationCode);
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string VerificationCode { get; set; }
    }
}
