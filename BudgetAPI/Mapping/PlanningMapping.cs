using AutoMapper;
using BudgetTracking.DtoLayer.PlanningDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class PlanningMapping:Profile
    {
        public PlanningMapping()
        {
            CreateMap<Planning, ResultPlanningDto>().ReverseMap();
            CreateMap<Planning, CreatePlanningDto>().ReverseMap();
            CreateMap<Planning, GetPlanningDto>().ReverseMap();



        }
    }
}
