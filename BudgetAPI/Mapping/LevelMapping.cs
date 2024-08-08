using System.Net.Security;
using System.Runtime;
using AutoMapper;
using BudgetTracking.DtoLayer.LevelsDto;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetAPI.Mapping
{
    public class LevelMapping :Profile
    {

        public LevelMapping()
        {

            CreateMap<Level, ResultLevelDto>().ReverseMap();
            CreateMap<Level, CreateLevelDto>().ReverseMap();

            CreateMap<Level, GetLevelDto>().ReverseMap();

            CreateMap<Level, UpdateLevelDto>().ReverseMap();

        }
    }
}
