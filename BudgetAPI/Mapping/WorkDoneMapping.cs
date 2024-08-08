
using BudgetTracking.DtoLayer.WorkDoneDto;

using BudgetTracking.EntityLayer.Entities;
using AutoMapper;


namespace BudgetAPI.Mapping
{
    public class WorkDoneMapping:Profile
    {
        public WorkDoneMapping()
        {
            CreateMap<WorkDone, ResultWorkDoneDto>().ReverseMap();
            CreateMap<WorkDone, CreateWorkDoneDto>().ReverseMap();

            CreateMap<WorkDone, GetWorkDoneDto>().ReverseMap();

            CreateMap<WorkDone, UpdateWorkDoneDto>().ReverseMap();
        }
    }
}
