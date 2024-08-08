using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.BudgetDto;
using BudgetTracking.EntityLayer.Entities;
using AutoMapper;
using BudgetTracking.DtoLayer.BudgetAmountDto;
using BudgetTracking.DtoLayer.AppControlDto;
namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppControlController : ControllerBase
    {
        private readonly IAppControlService _appControlService;
        private readonly IMapper _mapper;

        public AppControlController(IAppControlService appControlService, IMapper mapper)
        {
            _appControlService = appControlService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult AppControlList()
        {
            var values = _mapper.Map<List<ResultAppControlDto>>(_appControlService.TGetAll());
            return Ok(values);
        }

        [HttpGet("GetAppControl")]
        public IActionResult GetAppControl(int id)
        {
            var value = _appControlService.TGetByID(id);
            return Ok(value);

        }

    }
}
