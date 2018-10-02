using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }

        public DbSet<ContactModel> Contacts { get; set; }
    }
}
