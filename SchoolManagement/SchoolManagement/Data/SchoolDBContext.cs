using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.Data
{
    public class SchoolDBContext :DbContext
    {


        public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
            : base(options)
        {

        }
        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
