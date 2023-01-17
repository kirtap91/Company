using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Companies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IDbService _db;

        public CompaniesController(IDbService db)
        {
            _db = db;
        }
        // GET: api/<CompaniesController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            var employeeinfo = await _db.GetAsync<EmployeeInfo, EmployeeInfoDTO>();
            return Results.Ok(employeeinfo);
        }

        // GET api/<CompaniesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            var employeeinfo = await _db.SingleAsync<EmployeeInfo, EmployeeInfoDTO>(ei => ei.Id.Equals(id));
            return Results.Ok(employeeinfo);
        }

        // POST api/<CompaniesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeeInfoDTO dto)
        {
            if (dto is null) return Results.BadRequest();
            var employeeinfo = await _db.AddAsync<EmployeeInfo, EmployeeInfoDTO>(dto);
            return Results.Ok(employeeinfo);
        }

        // PUT api/<CompaniesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompaniesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
