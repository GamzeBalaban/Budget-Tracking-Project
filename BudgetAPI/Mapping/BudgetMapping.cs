using AutoMapper;
using BudgetTracking.DtoLayer.BudgetDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class BudgetMapping:Profile
    {
        public BudgetMapping()
        {
            CreateMap<Budget, ResultBudgetDto>().ReverseMap();
            CreateMap<Budget, CreateBudgetDto>().ReverseMap();
            CreateMap<Budget, GetBudgetDto>().ReverseMap();
            CreateMap<Budget, UpdateBudgetDto>().ReverseMap();
        }
    }
}
