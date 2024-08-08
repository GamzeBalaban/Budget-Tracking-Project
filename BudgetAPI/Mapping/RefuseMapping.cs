using AutoMapper;
using BudgetTracking.DtoLayer.RefuseDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class RefuseMapping:Profile
    {

        public RefuseMapping()
        {
            CreateMap<Refuse, ResultRefuseDto>().ReverseMap();
            CreateMap<Refuse, GetRefuseDto>().ReverseMap();
            CreateMap<Refuse, CreateRefuseDto>().ReverseMap();


        }
    }
}
