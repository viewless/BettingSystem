using AutoMapper;
using BettingSystem.Models.ResponseModels;
using BettingSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BettingSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMatchService _matchService;

        public MatchController(IMapper mapper,
        IMatchService matchService)
        {
            _matchService = matchService;
            _mapper = mapper;
           
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var match = await _matchService.GetMatchesAsync();

            if (match is null)
            {
                return NotFound($"Matches could not be found in the database.");
            }

            return Ok(_mapper.Map<MatchResponse>(match));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var match = await _matchService.GetMatchAsync(id);

            if (match is null)
            {
                return NotFound($"Matche it id {id} could not be found in the database.");
            }

            return Ok(_mapper.Map<MatchResponse>(match));
        }
    }
}
