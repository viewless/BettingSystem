using BettingSystem.DataAccess.Interfaces;
using BettingSystem.Models.ServiceModels;
using BettingSystem.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BettingSystem.Services.Services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _matchRepository;
       
        public MatchService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<MatchModel> GetMatchAsync(int id)
        {
            return await _matchRepository.GetMatchAsync(id);
        }

        public async Task<ICollection<MatchModel>> GetMatchesAsync()
        {
            return await _matchRepository.GetMatchesAsync();
        }

       
    }
}
