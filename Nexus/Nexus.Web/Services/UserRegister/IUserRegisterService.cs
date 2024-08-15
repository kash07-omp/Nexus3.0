using Nexus.Domain.Entities;

namespace Nexus.Web.Services.UserRegister
{
    public interface IUserRegisterService
    {
        Task<Region> AssignUserToRegionAsync(User user);
    }
}
