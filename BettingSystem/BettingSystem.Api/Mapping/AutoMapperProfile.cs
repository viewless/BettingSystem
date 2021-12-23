using AutoMapper;
using BettingSystem.DataAccess.Entities;
using BettingSystem.Models.ResponseModels;
using BettingSystem.Models.ServiceModels;
using XmlDeserialization;

namespace BettingSystem.Api.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<OddDto, OddEntity>();
            CreateMap<BetDto, BetEntity>();
            CreateMap<EventDto, EventEntity>();
            CreateMap<MatchDto, MatchEntity>();
            CreateMap<SportDto, SportEntity>();
            CreateMap<XmlSportsDto, XmlSportsEntity>();
           
           
            CreateMap<OddModel, OddResponse>();
            CreateMap<BetModel, BetResponse>();
            CreateMap<MatchModel, MatchResponse>();





            CreateMap<MatchModel, MatchEntity>().ForMember(dest => dest.Bets, opt => opt.MapFrom(src => src.Bets));
            CreateMap<OddModel, OddEntity>();
            CreateMap<BetModel, BetEntity>().ForMember(dest => dest.Odds, opt => opt.MapFrom(src => src.Odd));
            CreateMap<MatchEntity, MatchModel>();

            CreateMap<OddEntity, OddModel>();

            CreateMap<BetEntity, BetModel>();
        }
    }
}
