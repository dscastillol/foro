using Foro.Dtos;
using Foro.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Profiles
{
    public class PublicacionProfile : Profile
    {
        public PublicacionProfile()
        {
            CreateMap<Publicacion, PublicacionReadDto>();
            CreateMap<PublicacionCreateDto, Publicacion>();
        }
    }
}
