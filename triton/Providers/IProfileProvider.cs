using triton.Models;

namespace triton.Providers
{
    public interface IProfileProvider
    {
        ProfileModel GetModel();
    }
}