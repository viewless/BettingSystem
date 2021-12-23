using BettingSystem.Models.ServiceModels;
using BettingSystem.Tests.Fixtures;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace BettingSystem.Tests
{
    public class MatchServiceTests : IClassFixture<MatchServiceFixture>
    {
        private readonly MatchServiceFixture _matchServiceFixture;

        public MatchServiceTests(MatchServiceFixture matchServiceFixture)
        {
            _matchServiceFixture = matchServiceFixture;
        }

        [Fact]
        public async Task When_RetrievingAMatchId_Expect_MatchModel()
        {
            //Arrange
            var match = new MatchModel
            {
                Name = "eStar Pro - Wolves",
                Id = 2222418,
                StartDate = Convert.ToDateTime("2021-12-16T11:00:00"),
                MatchType = "Live",
                Bets = new BetModel 
                    {
                        Name = "Match Winner",
                        ID = 35631576,
                        IsLive = true,
                        Odd = new OddModel
                        {
                            Name = "1",
                            ID = 229932159,
                            Value = 1.25,
                            SpecialBetValue = 5.2
                        }
                }
            };

            _matchServiceFixture.MatchRepository.Setup(bookRepository => bookRepository.GetMatchAsync(1))
                .ReturnsAsync(match);

            //Act
            var bookResult = await _matchServiceFixture.MatchService.GetMatchAsync(1);

            //Assert
            Assert.Equal(bookResult, match);
        }
    }
}
