using AutoMapper;
using BudgetTracking.DtoLayer.ExpensesDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class ExpensesMapping :Profile
    {

        public ExpensesMapping() {

            CreateMap<Expenses, ResultExpensesDto>().ReverseMap();
            CreateMap<Expenses, CreateExpensesDto>().ReverseMap();
            CreateMap<Expenses, GetExpensesDto>().ReverseMap();
            CreateMap<Expenses, UpdateExpensesDto>().ReverseMap();

        }
    }
}
