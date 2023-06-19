using Microsoft.EntityFrameworkCore;
using TicketsDetalles.Models;

namespace TicketsDetalles.DAL
{
    public class DetalleContext : DbContext
    {
        public DetalleContext(DbContextOptions<DetalleContext> Options)
            : base(Options) { }

        public DbSet<TicketsDetalle> Detalle { get; set; }
    }
}
