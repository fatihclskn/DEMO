using Core.Utilities.Results;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using Entity.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string Password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string Email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
