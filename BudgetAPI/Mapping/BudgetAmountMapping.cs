using AutoMapper;
using BudgetTracking.DtoLayer.BudgetAmountDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class BudgetAmountMapping : Profile
    {

        public BudgetAmountMapping()
        {
            CreateMap<BudgetAmount, ResultBudgetAmountDto>().ReverseMap();
            CreateMap<BudgetAmount, CreateBudgetAmountDto>().ReverseMap();

            CreateMap<BudgetAmount, GetBudgetAmountDto>().ReverseMap();

            CreateMap<BudgetAmount, UpdateBudgetAmountDto>().ReverseMap();
        }

    }
}
