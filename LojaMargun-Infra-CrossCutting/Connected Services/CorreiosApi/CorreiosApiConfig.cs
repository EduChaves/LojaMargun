using Calculate;
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

        public async Task<CorreiosResponse> FreightCalculate(string value)
        {
            var response = await FindLocation(value);
            var calculate = new CalcPrecoPrazoWSSoapClient(CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap);
            var freightResult = await calculate.CalcPrecoPrazoAsync(string.Empty, string.Empty, "40010", "37701275",
            value, "1", 1, 15, 15, 15, 20, "N", 30, "S");

            if (freightResult != null)
            {
                response.ArrivelTime = freightResult.Servicos[0].PrazoEntrega;
                response.Value = freightResult.Servicos[0].Valor;
            }                
            else return null;

            return response;
        }
    }
}
