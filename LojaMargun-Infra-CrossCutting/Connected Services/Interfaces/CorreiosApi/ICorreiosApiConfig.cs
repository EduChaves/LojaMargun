using LojaMargun_Infra_CrossCutting.Connected_Services.CorreiosApi;
using System.Threading.Tasks;

namespace LojaMargun_Infra_CrossCutting.Connected_Services.Interfaces.CorreiosApi
{
    public interface ICorreiosApiConfig
    {
        public Task<CorreiosResponse> FindLocation(string value);
    }
}
