using CorreiosApi;
using LojaMargun_Infra_CrossCutting.Connected_Services.Interfaces.CorreiosApi;
using System.Threading.Tasks;

namespace LojaMargun_Infra_CrossCutting.Connected_Services.CorreiosApi
{
    public class CorreiosApiConfig : ICorreiosApiConfig
    {
        public async Task<CorreiosResponse> FindLocation(string value)
        {
            var tst = new AtendeClienteClient();
            var response = await tst.consultaCEPAsync(value);

            return response != null ? new CorreiosResponse
            {
                Address = response.@return.end,
                Complement = response.@return.complemento2,
                District = response.@return.bairro,
                State = response.@return.uf,
                City = response.@return.cidade
            } : null;
        }
    }
}
