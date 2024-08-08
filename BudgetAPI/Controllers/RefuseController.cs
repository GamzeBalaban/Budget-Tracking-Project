using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.PlanningDto;
using BudgetTracking.DtoLayer.RealizationDto;
using BudgetTracking.DtoLayer.RefuseDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefuseController : ControllerBase
    {
        private readonly IRefuseService _refuseService;
        private readonly IMapper _mapper;

        public RefuseController(IRefuseService refuseService ,IMapper mapper)
        {
            _refuseService = refuseService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RefuseList()
        {
            var values = _mapper.Map<List<ResultRefuseDto>>(_refuseService.TGetAll());
            return Ok(values);

        }
        [HttpPost]

        public IActionResult CreateRefuse(CreateRefuseDto createRefuseDto)
        {
            Refuse refuse = new Refuse()
            {
               RefuseID = createRefuseDto.RefuseID,

                RefuseReason = createRefuseDto.RefuseReason,
    
            };

            _refuseService.TAdd(refuse);
            return Ok("Reddedilme sebebi:.");
        }

    
    
        [HttpGet("GetRefuse")]
        public IActionResult GetRefuse(int id)
        {
            var value = _refuseService.TGetByID(id);
            return Ok(value);
        }
    }
}
