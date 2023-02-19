using Microsoft.EntityFrameworkCore;
using dotnetWebApi.Models;

namespace dotnetWebApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public virtual DbSet<GamePlayer> GamePlayers {get; set;}
        public virtual DbSet<GameObj> GamesObj {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 32));
            var ConnectionString = "server=127.0.0.1;port=3306;user=florenzi;password=flor13975;database=dotnetWebApi";
            optionsBuilder
                .UseMySql(ConnectionString, serverVersion)
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}