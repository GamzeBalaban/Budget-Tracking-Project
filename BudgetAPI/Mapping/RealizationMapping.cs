using AutoMapper;
using BudgetTracking.DtoLayer.RealizationDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class RealizationMapping :Profile
    {
        public RealizationMapping()
        {
            CreateMap<Realization, ResultRealizationDto>().ReverseMap();

            CreateMap<Realization, GetRealizationDto>().ReverseMap();


        }
    }
}
