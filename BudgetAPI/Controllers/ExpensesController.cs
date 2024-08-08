using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.CompanyNameDto;
using BudgetTracking.DtoLayer.ExpensesDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
           private readonly IExpensesService _expensesService;
           private readonly IMapper _mapper;

         
        public ExpensesController(IExpensesService expensesService ,IMapper mapper)
            {
                _expensesService = expensesService;
            _mapper = mapper;
        }
            [HttpGet]
            public IActionResult ExpensesList()
            {
            var values = _mapper.Map<List<ResultExpensesDto>>(_expensesService.TGetAll());
            return Ok(values);
            }
            [HttpPost]
            public IActionResult CreateExpenses(CreateExpensesDto createExpensesDto)
            {
                Expenses expenses = new Expenses()
                {
                    ExpensesType = createExpensesDto.ExpensesType,
                    ExpensesID = createExpensesDto.ExpensesID
                };
                _expensesService.TAdd(expenses);
                return Ok("Gider Tertibi Yapıldı ");
            }
            [HttpDelete]
            public IActionResult DeleteExpenses(int id)
            {
                var value = _expensesService.TGetByID(id);
                _expensesService.TDelete(value);
                return Ok("Gider Tertibi Silindi");
            }
            [HttpPut]
            public IActionResult UpdateExpenses(UpdateExpensesDto updateExpensesDto)
            {
            _expensesService.TUpdate(new Expenses()
            {
                ExpensesType = updateExpensesDto.ExpensesType,
                    ExpensesID = updateExpensesDto.ExpensesID
                });
                return Ok("Gider Tertibi Güncellendi");

            }
            [HttpGet("GetExpenses")]
            public IActionResult GetExpenses(int id)
            {
                var value = _expensesService.TGetByID(id);
                return Ok(value);
            }
        }
    }

