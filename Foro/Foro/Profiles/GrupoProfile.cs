using AutoMapper;
using Foro.Dtos;
using Foro.Models;

namespace Foro.Profiles
{
    public class GrupoProfile : Profile
    {

        public GrupoProfile()
        {
            //Source --> Target 
            CreateMap<Grupo, GrupoReadDto>();
            CreateMap<GrupoCreateDto, Grupo>();
        }
    }
}
