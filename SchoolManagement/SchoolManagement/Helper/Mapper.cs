using AutoMapper;
using SchoolManagement.Data;
using SchoolManagement.Model;

namespace SchoolManagement.Helper
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            CreateMap<UserDetails, UserDetailsModel>();
            //CreateMap<UserDetails, UserDetailsModel>().ReverseMap();
        }
    }
}
