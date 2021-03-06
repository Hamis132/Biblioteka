using System.Threading.Tasks;
using Biblioteka.Infrastructure.DTO;

namespace Biblioteka.Infrastructure.Services
{
    public interface IUserService
    {
         Task RegisterAsync(string email, string username, string password);
         Task<UserDto> GetAsync(string email);
    }
}