using StuNote.Domain.Services;
using System.Threading.Tasks;

namespace StuNote.Infrastructure
{
    public class SignInService : ISignInService
    {
        private bool _isSignedIn = false;
        private string _userName = string.Empty;

        public bool SignedIn => _isSignedIn;

        public string Username => _userName;

        public async Task<bool> LoginAsync(string Username, string Password)
        {
            _userName = Username;
            _isSignedIn = true;
            await Task.CompletedTask;
            return true;
        }
    }
}
