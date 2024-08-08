using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.BudgetAmountDto;
using BudgetTracking.DtoLayer.BudgetDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetService _budgetService;
        private readonly IMapper _mapper;
        public BudgetController(IBudgetService budgetService, IMapper mapper)
        {
            _budgetService = budgetService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult BudgetList()
        {
            var values = _mapper.Map<List<ResultBudgetDto>>(_budgetService.TGetAll());
            return Ok(values);

        }
        [HttpPost]
        public IActionResult CreateBudget(CreateBudgetDto createBudgetDto)
        {
            Budget budget = new Budget()
            {
                BudgetTypeID = createBudgetDto.BudgetTypeID,
                BudgetType = createBudgetDto.BudgetType
            };
            _budgetService.TAdd(budget);
            return Ok("Bütçe Tipi başarıyla eklendi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBudget(int id)
        {
            var value = _budgetService.TGetByID(id);
            _budgetService.TDelete(value);
            return Ok("Bütçe Tipi Silindi.");

        }
        [HttpPut]
        public IActionResult UpdateBudget(UpdateBudgetDto updateBudgetDto)
        {
            _budgetService.TUpdate(new Budget()
            {
                BudgetTypeID = updateBudgetDto.BudgetTypeID,
                BudgetType = updateBudgetDto.BudgetType
            });
            return Ok("Bütçe Tipi Güncellendi.");


        }
        [HttpGet("{id}")]
        public IActionResult GetBudget(int id)
        {
            var value = _budgetService.TGetByID(id);
            return Ok(value);

        }
    }
}