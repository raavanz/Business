using dependency_injection;
using dependency_injection.Services;
using Microsoft.AspNetCore.Mvc;

[Route("GetEmp")]
[HttpGet]
public IEnumerable<Employee> GetEmployeeList1()
{
    var res = _employeeService.GetEmployee();
    return res;
}

[Route("GetDepartment")]
[HttpGet]
//[Authorize]
public IEnumerable<Department> GetDepartment()
{
    var res = _departmentService.getDepartmentDetails();
    return res;
}