using AutoMapper;
using BudgetTracking.DtoLayer.ApprovalDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class ApprovalMapping:Profile
    {
        public ApprovalMapping()
        {
            CreateMap<Approval, ResultApprovalDto>().ReverseMap();

            CreateMap<Approval, GetApprovalDto>().ReverseMap();


        }
    }
}
