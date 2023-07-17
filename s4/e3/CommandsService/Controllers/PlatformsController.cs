using AutoMapper;
using CommandsService.Data;
using Microsoft.AspNetCore.Mvc;
using CommandsService.Dtos;
using CommandsService.Models;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/[Controller]")]
    public class PlatformsController : ControllerBase
    {
        private readonly ICommandRepo _repository;
        private readonly IMapper _mapper;

        public PlatformsController(ICommandRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            Console.WriteLine("--> Getting platforms from CommandService");
            var platformItems = _repository.GetAllPlatforms();
            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItems));
        }

        private int IEnumerable<T>(IEnumerable<Platform> platformItems)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult TestInboundConnnection()
        {
            Console.WriteLine("--> Inbound POST # CommandService");
            return Ok("Inbound Test from Platforms Controller");
        }
    }
}