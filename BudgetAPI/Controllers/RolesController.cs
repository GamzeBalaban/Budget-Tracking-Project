using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.RealizationDto;
using BudgetTracking.DtoLayer.RolesDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _rolesService;
        private readonly IMapper _mapper;


        public RolesController(IRolesService rolesService , IMapper mapper)
        {
            _rolesService = rolesService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult RolesList()
        {
            var values = _mapper.Map<List<ResultRolesDto>>(_rolesService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateRoles(CreateRolesDto createRolesDto)
        {
            Roles roles = new Roles()
            {
                RoleID = createRolesDto.RoleID,
                PersonelState = createRolesDto.PersonelState,
                PersonelRoles = createRolesDto.PersonelRoles

            };
            _rolesService.TAdd(roles);
            return Ok("Rol Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteRoles(int id)
        {
            var value = _rolesService.TGetByID(id);
            _rolesService.TDelete(value);
            return Ok("Rol Silindi");


        }
        [HttpPut]
        public IActionResult UpdateRoles(UpdateRolesDto updateRolesDto)
        {
            _rolesService.TUpdate(new Roles()
            {
                RoleID = updateRolesDto.RoleID,
                PersonelRoles = updateRolesDto.PersonelRoles,
                PersonelState = updateRolesDto.PersonelState
            });
            return Ok("Rol Güncellendi");
        }
        [HttpGet("GetRoles")]
        public IActionResult GetRoles(int id)
        {
            var value = _rolesService.TGetByID(id);
            return Ok(value);
        }
    }
}
