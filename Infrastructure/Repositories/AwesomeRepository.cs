using Domain.Abstract;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class AwesomeRepository : IAwesomeRepository
    {
        public async Task<AwesomeEntity> GetAwesomeEntity()
        {
            return await Task.Run(() => new AwesomeEntity()
            {
                Value = "This is awesome!!"
            });
        }
    }
}
