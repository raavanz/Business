using Business.Interface;
using Microsoft.AspNetCore.Mvc;

namespace dependency_injection
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeDetails employeeService,
     IDepartmentDetails departmentService) : ControllerBase
    {
        private readonly IEmployeeDetails _employeeService = employeeService;
        private readonly IDepartmentDetails _departmentService = departmentService;
    }

    internal interface IDepartmentDetails
    {
    }
}