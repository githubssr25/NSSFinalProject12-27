using Microsoft.EntityFrameworkCore;

namespace NSSFinalProject12_27.Context
{
    public class NSSFinalProjectDbContext : DbContext
    {
        public NSSFinalProjectDbContext(DbContextOptions<NSSFinalProjectDbContext> options)
            : base(options)
        {
        }

    }

}