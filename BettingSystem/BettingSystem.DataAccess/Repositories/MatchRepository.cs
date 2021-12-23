using AutoMapper;
using BettingSystem.DataAccess.Interfaces;
using BettingSystem.Models.ServiceModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace BettingSystem.DataAccess.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly IMapper _mapper;
        private readonly BettingSystemContext _bettingSystemContext;

        public MatchRepository(IMapper mapper,
            BettingSystemContext bettingSystemContext)
        {
            _mapper = mapper;
            _bettingSystemContext = bettingSystemContext;
        }

        public async Task<MatchModel> GetMatchAsync(int id)
        {

            var match = await _bettingSystemContext.Matches
                .AsNoTracking()
                .Include(bet => bet.Bets)
                .ThenInclude(odd => odd.Odds)
                .Where(x => x.Id == id)
                .Select(bet => bet.Bets.Where(bet => bet.IsLive == true))
                .FirstOrDefaultAsync();

            return _mapper.Map<MatchModel>(match);
        }

        public async Task<ICollection<MatchModel>> GetMatchesAsync()
        {
            var matches = await _bettingSystemContext.Matches
                .AsNoTracking()
                .Include(bet => bet.Bets)
                .ThenInclude(odd => odd.Odds)
                .Select(bet => bet.Bets.Where(bet => bet.IsLive == true))
                .ToListAsync();

            return _mapper.Map<ICollection<MatchModel>>(matches);
        }
    }
}
