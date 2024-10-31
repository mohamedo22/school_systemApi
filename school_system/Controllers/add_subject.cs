using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using school_system.interfaces_repo;
using school_system.models;

namespace school_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class add_subject : ControllerBase
    {
        private readonly IRepositorySubject repo_;
        public add_subject(IRepositorySubject repo)
        {

            repo_ = repo;
        }
        [HttpPost]
        public IActionResult add(subject_Dot subject_Dot)
        {
            return repo_.AddSubject(subject_Dot)?Ok():BadRequest();
        }
    }
}
