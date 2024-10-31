using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using school_system.interfaces_repo;
using school_system.models;

namespace school_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class deleteStudent : ControllerBase
    {
        private readonly IRepositoryStudent repo_;
        public deleteStudent(IRepositoryStudent repo)
        {

            repo_ = repo;
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            return repo_.DeleteStudent(id) ? Ok() : BadRequest();
        }
    }
}
