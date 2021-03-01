using triton.Models;

namespace triton.Services
{
    public interface IProfileService
    {

        ProfileModel GetProfileModel(string userId);
    }
}