using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using school_system.interfaces_repo;
using school_system.Jwt;
using school_system.models;

namespace school_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class register : ControllerBase
    {
        private readonly IRepositoryStudent repo_;
        private readonly IToken token_;
        public register(IRepositoryStudent repo , IToken token)
        {
            repo_ = repo;
            token_ = token;
        }
        [HttpPost]
        public IActionResult addstudent(students_Dot students_Dot)
        {
                var Jwt = token_.GeterateJwtToken();
               return repo_.AddNewStudent(students_Dot) ? Ok(Jwt): BadRequest();
        }
    }
}
