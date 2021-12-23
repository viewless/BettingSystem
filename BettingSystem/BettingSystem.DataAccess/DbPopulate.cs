using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using XmlDeserialization;

namespace BettingSystem.DataAccess
{
    public class DbPopulate
    {
        private readonly IMapper _mapper;

        public DbPopulate()
        {

        }
        public DbPopulate(IMapper mapper)
        {
            _mapper = mapper;
        }
        public static async Task Initialize(BettingSystemContext context)
        {
            await new DbPopulate().Seed(context);
        }
        public async Task Seed(BettingSystemContext context)
        {
            var deserializedData = Deserialization.Deserialize();
            var data =_mapper.Map<XmlSportsDto>(deserializedData);

            await context.AddRangeAsync(data);
            await context.SaveChangesAsync();

            Thread.Sleep(10_000);

            await Seed(context);
        }
    }
}
