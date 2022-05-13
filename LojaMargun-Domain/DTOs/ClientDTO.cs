namespace LojaMargun_Domain.DTOs
{
    public class ClientDTO : DTOBase
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string UserId { get; set; }
        public UserDTO User { get; set; }
        public int BagId { get; set; }
        public BagDTO Bag { get; set; }
        public bool Active { get; set; }
    }
}
