using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using school_system.interfaces_repo;
using school_system.models;

namespace school_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class return_students : ControllerBase
    {
        private readonly IRepositoryStudent repo_;
        public return_students(IRepositoryStudent repo) {

            repo_ = repo;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Return()
        { 
            return Ok(repo_.ReturnAllStudent());
        }
    }
}
