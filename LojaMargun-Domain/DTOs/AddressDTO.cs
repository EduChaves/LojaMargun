namespace LojaMargun_Domain.DTOs
{
    public class AddressDTO : DTOBase
    {
        public string Stret { get; set; }
        public int Number { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Complement { get; set; }
        public int Cep { get; set; }
        public int ClientId { get; set; }
        public ClientDTO Client { get; set; }
    }
}
