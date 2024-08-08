using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.PlanningDto;
using BudgetTracking.DtoLayer.RealizationDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealizationController : ControllerBase
    {
        private readonly IRealizationService _realizationService;
        private readonly IMapper _mapper;

        public RealizationController(IRealizationService realizationService, IMapper mapper)
        {
            _realizationService = realizationService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult RealizationList()
        {
            var values = _mapper.Map<List<ResultRealizationDto>>(_realizationService.TGetAll());
            return Ok(values);


        }
        [HttpDelete]

        public IActionResult DeleteRealization(int id)
        {
            var value = _realizationService.TGetByID(id); ;
            _realizationService.TDelete(value);
            return Ok("Gerçekleştirme planı silindi.");

        }
        [HttpGet("GetRealizatiın")]
        public IActionResult GetRealization(int id)
        {
            var value = _realizationService.TGetByID(id);
            return Ok(value);
        }
    }
}
