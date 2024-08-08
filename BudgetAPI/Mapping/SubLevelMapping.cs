
using BudgetTracking.DtoLayer.SubLevelDto;
using BudgetTracking.EntityLayer.Entities;
using AutoMapper;

namespace BudgetAPI.Mapping
{
    public class SubLevelMapping:Profile
    {

        public SubLevelMapping() {

            CreateMap<SubLevel, ResultSubLevelDto>().ReverseMap();
            CreateMap<SubLevel, CreateSubLevelDto>().ReverseMap();

            CreateMap<SubLevel, GetSubLevelDto>().ReverseMap();

            CreateMap<SubLevel, UpdateSubLevelDto>().ReverseMap();
        }
    }
}
