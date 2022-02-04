namespace LojaMargun_Domain.DTOs
{
    public class ClientDTO
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public UserDTO User { get; set; }
    }
}
