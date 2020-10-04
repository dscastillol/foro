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
    [Route("api/comentarios")]
    [ApiController]
    public class ComentarioController : ControllerBase
    {
        private readonly IForoRepo _repository;
        private readonly IMapper _mapper;

        public ComentarioController(IForoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ComentarioReadDto>> GetAllComentarios()
        {
            var comentarioItems = _repository.GetAllComentarios();

            return Ok(_mapper.Map<IEnumerable<ComentarioReadDto>>(comentarioItems));
        }

        [HttpGet("{id}")]
        public ActionResult<ComentarioReadDto> GetComentarioById(int id)
        {
            var comentarioItem = _repository.GetComentarioById(id);

            if (comentarioItem != null)
            {
                return Ok(_mapper.Map<ComentarioReadDto>(comentarioItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<ComentarioReadDto> CreateComentario(ComentarioCreateDto comentarioCreateDto)
        {
            var comentarioModel = _mapper.Map<Comentario>(comentarioCreateDto);
            _repository.CreateComentario(comentarioModel);
            _repository.SaveChanges();

            return Ok(comentarioModel);
        }

    }
}