using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Abstract
{
    public interface IAwesomeRepository
    {
        Task<AwesomeEntity> GetAwesomeEntity();
    }
}
