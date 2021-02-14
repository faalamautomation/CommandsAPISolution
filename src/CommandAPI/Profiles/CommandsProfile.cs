using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CommandAPI.Dtos;
using CommandAPI.Models;

namespace CommandAPI.Profiles
{
    public class CommandsProfile:Profile
    {
        public CommandsProfile()
        {
            //GET
            CreateMap<Command, CommandReadDto>();
            
            //POST
            CreateMap<CommandCreateDto, Command>();
            
            //PUT
            CreateMap<CommandUpdateDto, Command>();

            //Patch
            CreateMap<Command, CommandUpdateDto>();
        }


    }
}
