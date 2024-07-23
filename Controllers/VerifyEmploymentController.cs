using Microsoft.AspNetCore.Mvc;

namespace EmploymentVerification.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VerifyEmploymentController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public VerifyEmploymentController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public IActionResult VerifyEmployment([FromBody] EmploymentVerificationRequest request)
        {
            var verified = _employeeService.VerifyEmployment(request.EmployeeId, request.CompanyName, request.VerificationCode);
            return Ok(new { Verified = verified });
        }
    }

    public class EmploymentVerificationRequest
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string VerificationCode { get; set; }
    }
}
