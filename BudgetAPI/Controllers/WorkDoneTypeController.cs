using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.VATDto;
using BudgetTracking.DtoLayer.WorkDoneTypeDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkDoneTypeController : ControllerBase
    {
        private readonly IWorkDoneTypeService _workDoneTypeService;
        private readonly IMapper _mapper;


        public WorkDoneTypeController(IWorkDoneTypeService workDoneTypeService,IMapper mapper)
        {
            _workDoneTypeService = workDoneTypeService;
            _mapper = mapper;
            

        }

        [HttpGet]
        public IActionResult WorkDoneTypeList()
        {
            var values = _mapper.Map<List<ResultWorkDoneTypeDto>>(_workDoneTypeService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWorkDoneType(CreateWorkDoneTypeDto createWorkDoneTypeDto)
        {
            WorkDoneType workdone = new WorkDoneType()
            {
                WorkDoneTypeName = createWorkDoneTypeDto.WorkDoneTypeName,
                WorkDoneTypeID = createWorkDoneTypeDto.WorkDoneTypeID,
            };

            _workDoneTypeService.TAdd(workdone);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteWorkDoneType(int id)
        {
            var value = _workDoneTypeService.TGetByID(id);
            _workDoneTypeService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public IWorkDoneTypeService UpdateWorkDoneType(UpdateWorkDoneTypeDto updateWorkDoneTypeDto)
        {
            _workDoneTypeService.TUpdate(new WorkDoneType()
            {
                WorkDoneTypeName = updateWorkDoneTypeDto.WorkDoneTypeName,
                WorkDoneTypeID = updateWorkDoneTypeDto.WorkDoneTypeID,
            });

            return (IWorkDoneTypeService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetWorkDoneType")]

        public IActionResult GetWorkDoneType(int id)
        {
            var value = _workDoneTypeService.TGetByID(id);
            return Ok(value);

        }
    }
}
