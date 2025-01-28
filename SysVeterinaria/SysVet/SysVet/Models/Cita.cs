using SysVet.Models;

namespace SysVet.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }
        public int VeterinarioId { get; set; }
        public Usuario Veterinario { get; set; }
        public string Descripcion { get; set; }
    }
}