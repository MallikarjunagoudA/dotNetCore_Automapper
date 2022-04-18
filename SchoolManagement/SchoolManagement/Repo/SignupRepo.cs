using AutoMapper;
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
        private readonly IMapper _mapper;

        public SignupRepo(SchoolDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        } 


        public async Task<UserDetailsModel> GetUserdetails(int id)
        {
            //  var record = await _context.UserDetails.Select(x => new UserDetailsModel()
            //  {
            //      id =x.id,
            //      name = x.name,
            //      Role = x.Role,
            //      Emailid = x.Emailid,
            //      phone =x.phone 
            //  }
            //).Where(x => x.id == id).ToListAsync(); 
            //  return record;

            var record = await _context.UserDetails.FindAsync(id);
            return _mapper.Map<UserDetailsModel>(record);

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
