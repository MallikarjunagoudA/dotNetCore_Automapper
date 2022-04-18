using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data;
using SchoolManagement.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Repo
{
    public class SignupRepo : ISignup
    {

        public readonly SchoolDBContext _context;

        public SignupRepo(SchoolDBContext context)
        {
            _context = context;
        }


        public async Task<UserDetailsModel> GetUserdetails(int id)
        {
            var record = await _context.UserDetails.Select(x => new UserDetailsModel()
            {
                id =x.id,
                name = x.name,
                Role = x.Role,
                Emailid = x.Emailid,
                phone =x.phone
            }
          ).Where(x => x.id == id).ToListAsync(); 
            return record;
        }

        public async Task<int> AddUser(UserDetailsModel userDetails)
        {

            var ud = new UserDetails() {
                Emailid = userDetails.Emailid,
                Role = userDetails.Role,
                name = userDetails.name,
                phone=userDetails.phone
            };
            _context.UserDetails.Add(ud);
            await _context.SaveChangesAsync();
            return ud.id;
        }

    }
}
