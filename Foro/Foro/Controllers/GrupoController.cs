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
    [Route("api/grupos")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly IForoRepo _repository;
        private readonly IMapper _mapper;

        public GrupoController(IForoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GrupoReadDto>> GetAllGrupos()
        {
            var grupoItems = _repository.GetAllGrupos();

            return Ok(_mapper.Map<IEnumerable<GrupoReadDto>>(grupoItems));
        }

        [HttpGet("{id}")]
        public ActionResult<GrupoReadDto> GetGrupoById(int id)
        {
            var grupoItem = _repository.GetGrupoById(id);

            if (grupoItem != null)
            {
                return Ok(_mapper.Map<GrupoReadDto>(grupoItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<GrupoReadDto> CreateCommand(GrupoCreateDto grupoCreateDto)
        {
            var grupoModel = _mapper.Map<Grupo>(grupoCreateDto);
            _repository.CreateGrupo(grupoModel);
            _repository.SaveChanges();

            return Ok(grupoModel);
        }

    }
}