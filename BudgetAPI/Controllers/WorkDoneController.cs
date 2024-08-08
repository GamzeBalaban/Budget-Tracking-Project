using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.VATDto;
using BudgetTracking.DtoLayer.WorkDoneDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkDoneController : ControllerBase
    {
        private readonly IWorkDoneService _workDoneService;
        private readonly IMapper _mapper;


        public WorkDoneController(IWorkDoneService workDoneService, IMapper mapper)
        {
            _workDoneService = workDoneService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult WorkDoneList()
        {
            var values = _mapper.Map<List<ResultWorkDoneDto>>(_workDoneService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWorkDone(CreateWorkDoneDto createWorkDoneDto)
        {
            WorkDone workDone = new WorkDone()
            {
                WorkDoneName = createWorkDoneDto.WorkDoneName,
                WorkDoneID = createWorkDoneDto.WorkDoneID,

            };

            _workDoneService.TAdd(workDone);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteWorkDone(int id)
        {
            var value = _workDoneService.TGetByID(id);
            _workDoneService.TDelete(value);
            return Ok("Yapılan iş işlemi onaylanmadı.");
        }
        [HttpPut]
        public IWorkDoneService UpdateWorkDone(UpdateWorkDoneDto updateWorkDoneDto)
        {
            _workDoneService.TUpdate(new WorkDone()
            {
                WorkDoneName = updateWorkDoneDto.WorkDoneName,
                WorkDoneID = updateWorkDoneDto.WorkDoneID,

            });

            return (IWorkDoneService)Ok("Yapılan iş güncellendi.");

        }
        [HttpGet("GetWorkDone")]

        public IActionResult GetWorkDone(int id)
        {
            var value = _workDoneService.TGetByID(id);
            return Ok(value);

        }
    }
}
