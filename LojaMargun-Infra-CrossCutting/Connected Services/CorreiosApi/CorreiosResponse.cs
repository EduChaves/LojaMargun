using System.Collections.Generic;

namespace LojaMargun_Infra_CrossCutting.Connected_Services.CorreiosApi
{
    public class CorreiosResponse
    {
        public string Address { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ArrivelTime { get; set; }
        public string Value { get; set; }
    }
}
