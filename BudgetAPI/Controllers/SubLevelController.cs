using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.RolesDto;
using BudgetTracking.DtoLayer.SubLevelDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubLevelController : ControllerBase
    {
        private readonly ISubLevelService _subLevelService;
        private readonly IMapper _mapper;


        public SubLevelController(ISubLevelService subLevelService ,IMapper mapper)
        {
            _subLevelService = subLevelService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult SubLevelList()
        {
            var values = _mapper.Map<List<ResultSubLevelDto>>(_subLevelService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSublevel(CreateSubLevelDto createSubLevelDto)
        {
            SubLevel sublevel = new SubLevel()
            {
               
                SubLevelID = createSubLevelDto.SubLevelID,
                SubLevelNo = createSubLevelDto.SubLevelNo,
                SubLevelDescription = createSubLevelDto.SubLevelDescription,

            };
            _subLevelService.TAdd(sublevel);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteSubLevel(int id)
        {
            var value = _subLevelService.TGetByID(id);
            _subLevelService.TDelete(value);
            return Ok("Alt kod silindi.");
        }
        [HttpPut]
        public ISubLevelService UpdateSubLevel(UpdateSubLevelDto updateSubLevelDto)
        {
            _subLevelService.TUpdate(new SubLevel()
            {
                SubLevelID = updateSubLevelDto.SubLevelID,
                SubLevelNo = updateSubLevelDto.SubLevelNo,
                SubLevelDescription = updateSubLevelDto.SubLevelDescription,

            });

            return (ISubLevelService)Ok("Alt kod güncellendi.");

        }
        [HttpGet("GetSubLevel")]

        public IActionResult GetSubLevel(int id)
        {
            var value = _subLevelService.TGetByID(id);
            return Ok(value);

        }
    }
}
