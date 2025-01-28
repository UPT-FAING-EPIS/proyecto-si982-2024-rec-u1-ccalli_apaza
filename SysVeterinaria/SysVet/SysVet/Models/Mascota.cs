using SysVet.Models;

namespace SysVet.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int PropietarioId { get; set; }
        public Usuario Propietario { get; set; }
    }
}