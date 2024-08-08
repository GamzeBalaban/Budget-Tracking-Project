using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.UserDto;
using BudgetTracking.DtoLayer.VATDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VATController : ControllerBase
    {
        private readonly IVATService _vatService;
        private readonly IMapper _mapper;


        public VATController(IVATService vatService, IMapper mapper)
        {
            _vatService = vatService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult VATList()
        {
            var values = _mapper.Map<List<ResultVATDto>>(_vatService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateVAT(CreateVATDto createVATDto)
        {
            VAT vat = new VAT()
            {
                VATID = createVATDto.VATID,
                VATRate = createVATDto.VATRate,
            };

            _vatService.TAdd(vat);
            return Ok("Vergi yüzdesi başarılı bir şekilde eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteVAT(int id)
        {
            var value = _vatService.TGetByID(id);
            _vatService.TDelete(value);
            return Ok("Vergi yüzdesi onaylanmadı.");
        }
        [HttpPut]
        public IVATService UpdateVAT(UpdateVATDto updateVATDto)
        {
            _vatService.TUpdate(new VAT()
            {
                VATID = updateVATDto.VATID,
                VATRate = updateVATDto.VATRate,

            });

            return (IVATService)Ok("Vergi yüzdesi güncellendi.");

        }
        [HttpGet("GetVAT")]

        public IActionResult GetVAT(int id)
        {
            var value = _vatService.TGetByID(id);
            return Ok(value);

        }
    }
}
