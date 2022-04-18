using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolManagement.Model;
using SchoolManagement.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SchoolManagement.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class signupController : ControllerBase
    {
        private readonly ISignup _ISignUp;

        public signupController(ISignup isignup)
        {
            _ISignUp = isignup;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserDetails(int id)
        {
            
             var details = await _ISignUp.GetUserdetails(id);
            return Ok(details);
        }


        [HttpPost]
        public async Task<IActionResult> AddUser(UserDetailsModel bm)
        {


            var res = await _ISignUp.AddUser(bm);

            return CreatedAtAction("AddUser", res);
        }


    }
}
