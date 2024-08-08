using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DtoLayer.RolesDto;
using BudgetTracking.DtoLayer.SubLevelDto;
using BudgetTracking.DtoLayer.UserDto;
using BudgetTracking.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;


        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult UserList()
        {
            var values = _mapper.Map<List<ResultUserDto>>(_userService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateUser(CreateUserDto createUserDto)
        {
            User user = new User()
            {
                UserID = createUserDto.UserID,
               UserName= createUserDto.UserName,
               Email = createUserDto.Email,
               Password = createUserDto.Password,


            };
            _userService.TAdd(user);
            return Ok("Kişi Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            var value = _userService.TGetByID(id);
            _userService.TDelete(value);
            return Ok("Kişi Silindi");


        }
        [HttpPut]
        public IActionResult UpdateUser(UpdateUserDto updateUserDto)
        {
            _userService.TUpdate(new User()
            {
                UserID = updateUserDto.UserID,
                UserName = updateUserDto.UserName,
                Email = updateUserDto.Email,
                Password = updateUserDto.Password,
            });
            return Ok("Kişi Güncellendi");
        }
        [HttpGet("GetRoles")]
        public IActionResult GetRoles(int id)
        {
            var value = _userService.TGetByID(id);
            return Ok(value);
        }
    }
}
