using Microsoft.EntityFrameworkCore;

namespace lce.mis.api.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public class MisDbContext : DbContext
    {
        public MisDbContext(DbContextOptions<MisDbContext> options) : base(options) { }
    }
}
