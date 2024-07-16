using System.ComponentModel.DataAnnotations;

namespace RestAPIServer.Models
{
    public class Users
    {
        public string UserName { get; set; }
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }   
        public string CityCode { get; set; }
        public string Address { get; set; }

    }
}
