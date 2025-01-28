using SysVet.Models;

namespace SysVet.Models
{
    public class Historial
    {
        public int Id { get; set; }
        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int VeterinarioId { get; set; }
        public Usuario Veterinario { get; set; }
    }
}