using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Foro.Data;
using Foro.Dtos;
using Foro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foro.Controllers
{
    [Route("api/publicaciones")]
    [ApiController]
    public class PublicacionController : ControllerBase
    {
        private readonly IForoRepo _repository;
        private readonly IMapper _mapper;

        public PublicacionController(IForoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PublicacionReadDto>> GetAllPublicaciones()
        {
            var publicacionItems = _repository.GetAllPublicaciones();

            return Ok(_mapper.Map<IEnumerable<PublicacionReadDto>>(publicacionItems));
        }

        [HttpGet("{id}")]
        public ActionResult<PublicacionReadDto> GetPublicacionById(int id)
        {
            var publicacionItem = _repository.GetPublicacionById(id);

            if (publicacionItem != null)
            {
                return Ok(_mapper.Map<PublicacionReadDto>(publicacionItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<PublicacionReadDto> CreatePublicacion(PublicacionCreateDto publicacionCreateDto)
        {
            var publicacionModel = _mapper.Map<Publicacion>(publicacionCreateDto);
            _repository.CreatePublicacion(publicacionModel);
            _repository.SaveChanges();

            return Ok(publicacionModel);
        }

    }
}