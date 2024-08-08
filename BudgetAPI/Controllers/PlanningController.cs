using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.LevelsDto;
using BudgetTracking.DtoLayer.PlanningDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanningController : ControllerBase
    {
        private readonly IPlanningService _planningService;
        private readonly IMapper _mapper;


        public PlanningController(IPlanningService planningService,IMapper mapper)
        {
            _planningService = planningService;
            _mapper = mapper;


        }
        [HttpGet]
        public IActionResult PlanningList()
        {
            var values = _mapper.Map<List<ResultPlanningDto>>(_planningService.TGetAll());
            return Ok(values);

        }
        [HttpPost]

        public IActionResult CreatePlanning(CreatePlanningDto createPlanningDto)
        {
            Planning planning = new Planning()
            {
                PlanID = createPlanningDto.PlanID,

                ExcVAT = createPlanningDto.ExcVAT,
                InVAT = createPlanningDto.InVAT,
                PayStatus = createPlanningDto.PayStatus,
                UsableBudget = createPlanningDto.UsableBudget,
                AvailableBudget = createPlanningDto.AvailableBudget,
                RemaningBudget = createPlanningDto.RemaningBudget,
                TotalExpenditure = createPlanningDto.TotalExpenditure,

                Documents = createPlanningDto.Documents,



            };

            _planningService.TAdd(planning);
            return Ok("Plan başarıli bir şekilde eklendi.");
        }
        [HttpDelete]
        public IActionResult DeletePlanning(int id)
        {
            var value = _planningService.TGetByID(id);
            _planningService.TDelete(value);
            return Ok("Plan silindi.");
        }
       
        [HttpGet("GetPlanning")]
        public IActionResult GetPlanning(int id)
        {
            var value = _planningService.TGetByID(id);
            return Ok(value);


        }
    }
}
