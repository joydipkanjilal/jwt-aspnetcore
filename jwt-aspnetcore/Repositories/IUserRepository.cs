using JWTASPNetCore.Models;

namespace JWTASPNetCore
{
    public interface IUserRepository
    {
        UserDTO GetUser(UserModel userModel);
    }
}
