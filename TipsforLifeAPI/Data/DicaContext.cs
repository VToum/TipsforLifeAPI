using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TipsforLifeAPI.Entidades;

namespace TipsforLifeAPI.Data
{
    public class DicaContext : DbContext
    {
        public DicaContext(DbContextOptions<DicaContext> options) : base(options) { }

        public DbSet<DicaModel> dicas { get; set; }

    }
}
