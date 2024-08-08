
using BudgetTracking.DtoLayer.VATDto;

using BudgetTracking.EntityLayer.Entities;
using AutoMapper;


namespace BudgetAPI.Mapping
{
    public class VATMapping:Profile
    {
        public VATMapping()
        {
            CreateMap<VAT, ResultVATDto>().ReverseMap();
            CreateMap<VAT, CreateVATDto>().ReverseMap();

            CreateMap<VAT, GetVATDto>().ReverseMap();

            CreateMap<VAT, UpdateVATDto>().ReverseMap();
        }

    }
}
