using CorreiosApi;
using System.Threading.Tasks;

namespace LojaMargun_Infrastructure_CrossCutting.Connected_Services.CorreiosApi
{
    internal class CorreiosApiConfig
    {
        public async Task<CorreiosResponse> FindLocation(string value)
        {
            var tst = new AtendeClienteClient();
            var response = await tst.consultaCEPAsync(value);

            return response!= null ? new CorreiosResponse
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
