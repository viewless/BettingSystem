using BettingSystem.Models.ServiceModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BettingSystem.Services.Interfaces
{
    public interface IMatchService
    {
        Task<ICollection<MatchModel>> GetMatchesAsync();
        Task<MatchModel> GetMatchAsync(int id);
    }
}
