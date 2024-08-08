using AutoMapper;
using BudgetTracking.DtoLayer.WorkDoneTypeDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class WorkDoneTypeMapping:Profile
    {

        public WorkDoneTypeMapping()
        {

            CreateMap<WorkDoneType, ResultWorkDoneTypeDto>().ReverseMap();
            CreateMap<WorkDoneType, CreateWorkDoneTypeDto>().ReverseMap();

            CreateMap<WorkDoneType, GetWorkDoneTypeDto>().ReverseMap();

            CreateMap<WorkDoneType, UpdateWorkDoneTypeDto>().ReverseMap();
        }
    }
}
