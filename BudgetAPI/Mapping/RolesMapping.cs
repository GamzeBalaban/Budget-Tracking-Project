using AutoMapper;
using BudgetTracking.DtoLayer.RolesDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class RolesMapping:Profile
    {
        public RolesMapping()
        {
            CreateMap<Roles, ResultRolesDto>().ReverseMap();
            CreateMap<Roles, CreateRolesDto>().ReverseMap();

            CreateMap<Roles, GetRolesDto>().ReverseMap();
            CreateMap<Roles, UpdateRolesDto>().ReverseMap();






        }
    }
}
