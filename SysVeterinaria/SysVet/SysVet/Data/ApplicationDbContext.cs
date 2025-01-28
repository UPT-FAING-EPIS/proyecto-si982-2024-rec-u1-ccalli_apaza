using SysVet.Models; // Asegúrate de que este namespace coincida con tu estructura de carpetas

namespace SysVet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Historial> Historiales { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
    }
}