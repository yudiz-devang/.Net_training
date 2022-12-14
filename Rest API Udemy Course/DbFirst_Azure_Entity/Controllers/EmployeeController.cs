using DbFirst_Azure_Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbFirst_Azure_Entity.Controllers
{
    //This Employee Controller will execute all operation direct to DB with procedure
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _dbContext;
        public EmployeeController(ILogger<EmployeeController> logger
            , EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetEmployee")]
        //Get Employee by ID
        public async Task<IEnumerable<Employee>> EmployeeNames(int id)
        {
            var AuthorProfile = await _dbContext.Employees.FromSqlInterpolated($"Exec [dbo].[GetEmployees] @Id = {id}").ToListAsync();
            return AuthorProfile;
        }

        [HttpGet("GetEmployeeByPaging")]
        //Get Employee List by paging
        public async Task<IEnumerable<Employee>> GetEmployeeByPaging(int pageNumber, int pageSize)
        {
            var emp = (from p in _dbContext.Employees.OrderBy(a => a.Id) select p).AsQueryable();
            var items = emp.Skip((pageNumber
                - 1) * pageSize).Take(pageSize).ToList();
            return items;
        }
        
        [HttpPost("AddEmployee")]
        //Add Employee to DB
        public async Task<string> AddEmployees(AddEmployeeRequest request)
        {
            var emp = _dbContext.Database.ExecuteSqlRaw($"Exec [dbo].[InsertEmp] @Name = {request.Name}, @City={request.City},@DailyTypingPage ={request.DailyTypingPage}, @Score ={request.Score},@Salary={request.Salary}");
            return $"{emp} raw inserted";
        }
        
        [HttpPut("UpdateEmployee")]
        //Update Employee
        public async Task<string> UpdateEmployees(int id, AddEmployeeRequest request)
        {
            var emp = _dbContext.Database.ExecuteSqlRaw($"Exec [dbo].[UpdateEmployee] @id={id}, @Name = {request.Name}, @City={request.City},@daily_typing_page = {request.DailyTypingPage},@Score ={request.Score},@Salary ={request.Salary} ");
            return $"{emp} raw updated";
        }

        [HttpDelete("RemoveEmployee")]
        //Remove Employee
        public async Task<string> RemoveEmployee(int id)
        {
            var emp = _dbContext.Database.ExecuteSqlRaw($"Exec [dbo].[RemoveEmp] @Id = {id} ");
            return $"{emp} raw Deleted";
        }

        [HttpGet("GetAllEmployeeBySorting")]
        //Get Employee By order by asending and descending
        public async Task<IEnumerable<Employee>> Employees(string sortName)
        {
            //var AuthorProfile = await _dbContext.Employees.FromSqlInterpolated($"Exec [dbo].[GetProfile] ").ToListAsync();
            IQueryable<Employee> employees;
            switch (sortName)
            {
                case "desc":
                    employees = _dbContext.Employees.OrderByDescending(p => p.Name);
                    break;

                case "asc":
                    employees = _dbContext.Employees.OrderBy(p => p.Name);
                    break;

                default:
                    employees = _dbContext.Employees;
                    break;
            }
            return employees.ToList();
        }

        [HttpGet("GetSearchEmployee")]
        //Search Employee on Name 
        public async Task<IEnumerable<Employee>> GetSearchEmployee(string EnterName)
        {
            var search = _dbContext.Employees.Where(p => p.Name.ToLower().StartsWith(EnterName.ToLower()));
            return search.ToList();
        }

    }
}
