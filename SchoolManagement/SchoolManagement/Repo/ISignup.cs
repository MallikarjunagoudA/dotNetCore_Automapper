using SchoolManagement.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagement.Repo
{
    public interface ISignup
    {
        Task<int> AddUser(UserDetailsModel userDetails);
        Task<UserDetailsModel> GetUserdetails(int id);
    }
}
