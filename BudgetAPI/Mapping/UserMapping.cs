using AutoMapper;
using BudgetTracking.DtoLayer.UserDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class UserMapping : Profile
    {
       public UserMapping() { 
            CreateMap<User,ResultUserDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();



        }
    }
}
