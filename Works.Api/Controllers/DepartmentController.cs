using Microsoft.AspNetCore.Mvc;
using Works.Data.Entities;
using Works.Models;
using Works.Service;

namespace Works.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly ILogger<DepartmentController> logger;
        private readonly IDepartmentServices departmentServices;

        public DepartmentController(ILogger<DepartmentController> logger, IDepartmentServices departmentServices)
        {
            this.logger = logger;
            this.departmentServices = departmentServices;
        }

        
        [HttpPost("Post")]
        public async Task<IActionResult> Add(DepartmentViewModel department)
        {

           await departmentServices.Add(department);
            return Ok();
        }


        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var data = departmentServices.GetAll();
            return Ok(data);
        }



    }
}
