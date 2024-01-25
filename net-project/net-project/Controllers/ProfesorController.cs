using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using net_project.Data;
using net_project.Models;
using net_project.Models.DTOs;
using net_project.Models.Repositories;

namespace net_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly TemplateContext _context;
        private readonly IMapper _mapper;
        private readonly IProfesorRepository _profesorRepository;

        public ProfesorController(TemplateContext context, IMapper mapper, IProfesorRepository repository)
        {
            _context = context;
            _mapper = mapper;
            _profesorRepository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetProfesorDTO>>> GetProfesori()
        {
            var profesori = _mapper.Map<List<GetProfesorDTO>>(await _profesorRepository.GetAllProfesorsAsync());
            if (profesori == null)
            {
                return NotFound();
            }
            return profesori;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProfesor(string nume)
        {
            var prof = await _profesorRepository.GetProfesorAsync(nume);
            if (prof == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(prof);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProfesor(PostProfesorDTO profesorDto)
        {
            var newProf = await _profesorRepository.PostAsync(_mapper.Map<Profesor>(profesorDto));
            return Ok(newProf);
        }
        [HttpGet("materie")]
        public async Task<IActionResult> GetMaterii()
        {
            return Ok(await _context.Materii.ToListAsync());
        }

        /*        [HttpPost("profesor")]
                public async Task<IActionResult> GetUsers()
                {
                    return Ok(await _context.Profesori.ToListAsync());
                }*/
    }
}
