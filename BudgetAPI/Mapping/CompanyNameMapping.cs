using AutoMapper;
using BudgetTracking.DtoLayer.CompanyNameDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class CompanyNameMapping :Profile
    {

        public  CompanyNameMapping()
        {
            CreateMap<CompanyName, ResultCompanyNameDto>().ReverseMap();
            CreateMap<CompanyName, CreateCompanyNameDto>().ReverseMap();

            CreateMap<CompanyName, GetCompanyNameDto>().ReverseMap();

            CreateMap<CompanyName, UpdateCompanyNameDto>().ReverseMap();
        
    }
    }
}
