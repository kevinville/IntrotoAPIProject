using Microsoft.EntityFrameworkCore;

namespace WorkerSalaryAPI.Models
{
    public class SalaryDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public SalaryDbContext(DbContextOptions<SalaryDbContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
          
        }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionstring = Configuration.GetConnectionString("JobInformation");
            options.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring));
        }
        public DbSet<Worker> Worker { get; set; } = null!;
        public DbSet<PublicInfo> PublicInfo { get; set; } = null!;
    }
}
