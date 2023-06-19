using System.ComponentModel.DataAnnotations;

namespace TicketsDetalles.Models
{
    public class TicketsDetalle
    {
        [Required(ErrorMessage = "El Id requerido es obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El ticketId requerido es obligatorio")]
        public int TicktetId { get; set; }

        [Required(ErrorMessage = "El emisor requerido es obligatorio")]
        public string Emisor { get; set; }

        [Required(ErrorMessage = "Escribe un detalle en el mensaje")]
        public string Mensaje { get; set; }
    }
}
