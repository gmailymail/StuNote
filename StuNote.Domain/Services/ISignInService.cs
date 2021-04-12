using System.Threading.Tasks;

namespace StuNote.Domain.Services
{
    public interface ISignInService
    {
        Task<bool> LoginAsync(string Username, string Password);

        bool SignedIn { get; }

        string Username { get; }
    }
}
