using AutoMapper;
using MyFirstProject_MVC_Core.Dtos;
using MyFirstProject_MVC_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject_MVC_Core.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source --> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
