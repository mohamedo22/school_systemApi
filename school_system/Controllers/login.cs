using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using school_system.interfaces_repo;
using school_system.models;

namespace school_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class login : ControllerBase
    {
        private readonly IRepositoryStudent repo_;
        public login(IRepositoryStudent repo)
        {

            repo_ = repo;
        }
        [HttpPost]
        public IActionResult login_(student_Dot_login student)
        {
            return repo_.Login(student) ? Ok() : NotFound();
        }
    }
}
