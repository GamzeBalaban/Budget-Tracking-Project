using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.CompanyNameDto;
using BudgetTracking.DtoLayer.LevelsDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly ILevelService _levelService;
        private readonly IMapper _mapper;

        public LevelController(ILevelService levelService,IMapper mapper)
        {
            _levelService = levelService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult LevelList()
        {
            var values = _mapper.Map<List<ResultLevelDto>>(_levelService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateLevel(CreateLevelDto createLevelDto)
        {
            Level level = new Level()
            {
                LevelID = createLevelDto.LevelID,
                LevelNo = createLevelDto.LevelNo,

            };

            _levelService.TAdd(level);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteLevel(int id)
        {
            var value = _levelService.TGetByID(id);
            _levelService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public ILevelService UpdateLevel(UpdateLevelDto updateLevelDto)
        {
            _levelService.TUpdate(new Level()
            {

                LevelID = updateLevelDto.LevelID,
                LevelNo = updateLevelDto.LevelNo,


            });

            return (ILevelService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetLevels")]

        public IActionResult GetLevels(int id)
        {
            var value = _levelService.TGetByID(id);
            return Ok(value);

        }
    }
}
