using Microsoft.EntityFrameworkCore;


namespace Src.Connection
{

    public class NotaDbContext : DbContext
    {
        public NotaDbContext(DbContextOptions<NotaDbContext> options) : base(options)
        {
        }


    }
}