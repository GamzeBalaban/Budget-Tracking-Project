using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.BudgetAmountDto;
using BudgetTracking.DtoLayer.CompanyNameDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyNameController : ControllerBase
    {
        private readonly ICompanyNameService _companynameService;
        private readonly IMapper _mapper;


        public CompanyNameController(ICompanyNameService companynameService, IMapper mapper)
        {
            _companynameService = companynameService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CompanyNameList()
        {
            var values = _mapper.Map<List<ResultCompanyNameDto>>(_companynameService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCompanyName(CreateCompanyNameDto createCompanyNameDto)
        {
            CompanyName companyname = new CompanyName()
            {
                CompanyNames = createCompanyNameDto.CompanyNames,
                CompanyID = createCompanyNameDto.CompanyID,

            };

            _companynameService.TAdd(companyname);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteCompanyName(int id)
        {
            var value = _companynameService.TGetByID(id);
            _companynameService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public ICompanyNameService UpdateCompanyName(UpdateCompanyNameDto updateCompanyNameDto)
        {
            _companynameService.TUpdate(new CompanyName()
            {
                CompanyID = updateCompanyNameDto.CompanyID,
                CompanyNames = updateCompanyNameDto.CompanyNames,

            });

            return (ICompanyNameService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetCompanyName")]

        public IActionResult GetAddCompany(int id)
        {
            var value = _companynameService.TGetByID(id);
            return Ok(value);

        }

    }
}
