using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.ApprovalDto;
using BudgetTracking.DtoLayer.BudgetAmountDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalController : ControllerBase
    {
        private readonly IApprovalService _approvalService;
        private readonly IMapper _mapper;

        public ApprovalController(IApprovalService approvalService , IMapper mapper)
        {
            _approvalService = approvalService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ApprovalList()
        {
            var values = _mapper.Map<List<ResultApprovalDto>>(_approvalService.TGetAll());
            return Ok(values);
        }

        [HttpGet("GetApproval")]

        public IActionResult GetApproval(int id)
        {
            var value = _approvalService.TGetByID(id);
            return Ok(value);

        }
    }
}
