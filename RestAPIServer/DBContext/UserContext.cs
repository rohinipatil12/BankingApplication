using Microsoft.EntityFrameworkCore;
using RestAPIServer.Models;

namespace RestAPIServer.DBContext
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<Users> UsersList { get; set; } = null!;
    }
}
