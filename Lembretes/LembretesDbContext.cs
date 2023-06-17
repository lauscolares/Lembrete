using Lembretes.Models;
using Microsoft.EntityFrameworkCore;

namespace Lembretes
{
    public class LembreteContext : DbContext
    {
        public DbSet<Lembrete> Lembretes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=lembretes.db");
    }
}
