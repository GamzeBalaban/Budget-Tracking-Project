using System.Net.Security;
using System.Runtime;
using AutoMapper;
using BudgetTracking.DtoLayer.AppControlDto;
using BudgetTracking.EntityLayer.Entities;


namespace BudgetAPI.Mapping
{
    public class AppControlMapping :Profile
    {
        public AppControlMapping()
        {
            CreateMap<AppControl, ResultAppControlDto>().ReverseMap();
            CreateMap<AppControl, GetAppControlDto>().ReverseMap();
           
        }
    }
}
