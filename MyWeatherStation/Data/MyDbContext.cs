using Microsoft.EntityFrameworkCore;

namespace MyWeatherStation.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<sensordata> sensordata { get; set; }
    }
}
