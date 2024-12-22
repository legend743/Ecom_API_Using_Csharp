using Ecomm.Modal;
using Microsoft.EntityFrameworkCore;

namespace Ecomm.Data
{
    //db context file is actually a collection of db set
    public class ApllicationDbContext : DbContext
    {
        public ApllicationDbContext(DbContextOptions<ApllicationDbContext> options)
        : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; } = null!;
    }
} 