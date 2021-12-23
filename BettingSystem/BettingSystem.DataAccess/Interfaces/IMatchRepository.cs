using BettingSystem.Models.ServiceModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BettingSystem.DataAccess.Interfaces
{
    public interface IMatchRepository
    {
        Task<ICollection<MatchModel>> GetMatchesAsync();
        Task<MatchModel> GetMatchAsync(int id);
    }
}
