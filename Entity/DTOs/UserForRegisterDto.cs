using Core.Entities;

namespace Entity.DTOs
{
    public class UserForRegisterDto : IDto
    {
        public string Name { get; set; }
        public string DateTime { get; set; }
        public bool Gender { get; set; }
        public string Mail { get; set; }
        public int Phone { get; set; }
    }
}
