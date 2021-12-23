using AutoMapper;
using BettingSystem.DataAccess.Interfaces;
using BettingSystem.Services.Interfaces;
using BettingSystem.Services.Services;
using Moq;

namespace BettingSystem.Tests.Fixtures
{
    public class MatchServiceFixture
    {
        public Mock<IMatchRepository> MatchRepository { get; private set; }
        public IMatchService MatchService { get; private set; }
        public Mock<IMapper> Mapper { get; private set; }

        public MatchServiceFixture()
        {
            this.MatchRepository = new Mock<IMatchRepository>();
            this.MatchService = new MatchService(MatchRepository.Object);
            this.Mapper = new Mock<IMapper>();
        }
    }
}
