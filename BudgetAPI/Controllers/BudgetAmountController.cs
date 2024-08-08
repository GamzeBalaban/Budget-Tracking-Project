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
    public class BudgetAmountController : ControllerBase
    {
        private readonly IBudgetAmountService _budgetAmountService;
        private readonly IMapper _mapper;
        public BudgetAmountController(IBudgetAmountService budgetAmountService,IMapper mapper)
        {
            _budgetAmountService = budgetAmountService;
            _mapper =mapper;
        }
        [HttpGet]
        public IActionResult BudgetAmountList()
        {
            var values = _mapper.Map <List< ResultBudgetAmountDto >> (_budgetAmountService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBudgetAmount(CreateBudgetAmountDto createBudgetAmountDto)
        {
            _budgetAmountService.TAdd(new BudgetAmount()
            {
                BudgetAmountID = createBudgetAmountDto.BudgetAmountID,
                Amount = createBudgetAmountDto.Amount,

            } );
            return Ok("Bütçe talebi başarılı bir şekilde eklendi.");

        }
        [HttpDelete]
        public IActionResult DeleteBudgetAmount(int id)
        {
            var value = _budgetAmountService.TGetByID(id);
            _budgetAmountService.TDelete(value);
            return Ok("Bütçe talebi silindi.");

        }

        [HttpGet("GetBudgetAmount")]
        public IActionResult GetBudgetAmount(int id)
        {
            var value = _budgetAmountService.TGetByID(id);
            return Ok(value);

        }
   
    }
}
