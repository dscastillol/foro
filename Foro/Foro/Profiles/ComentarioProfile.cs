using AutoMapper;
using Foro.Dtos;
using Foro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Profiles
{
    public class ComentarioProfile : Profile
    {
        public ComentarioProfile()
        {
            //Source --> Target 
            CreateMap<Comentario, ComentarioReadDto>();
            CreateMap<ComentarioCreateDto, Comentario>();
        }
    }
}
