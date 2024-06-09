using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ToDoWebAPI.Domain.Entities;


namespace ToDoWebAPI.Application.ToDos.Common.Mappings
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ToDo, ToDoVm>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)).
                ForMember(dest => dest.Completed,
                    opt => opt.MapFrom(src => src.ToDoStatusesId == 1));

        }
    }
}
