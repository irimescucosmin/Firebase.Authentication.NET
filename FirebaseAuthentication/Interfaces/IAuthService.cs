using System.Security.Claims;
using Firebase.Auth;

namespace FirebaseAUTH.Interfaces;

public interface IAuthService
{
    public Task<string?> SignUp(string email, string password);
    public Task<ClaimsIdentity?> Login(string email, string password);
    public Task<UserInfo> UserInfo();
    public void SignOut();
}