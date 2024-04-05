using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class equipos
    {
        [Key]
        [Display(Name = "IdEquipo")]
        public int id_equipos { get; set; }

        [Display(Name = "Nombre")]
        public string? nombre { get; set; }

        [Display(Name = "Descripcion")]
        public string? descripcion { get; set; }

        [Display(Name = "TipoEquipo")]
        public int? tipo_equipo_id { get; set; }

        [Display(Name = "Marca")]
        public int? marca_id { get; set; }

        [Display(Name = "Modelo")]
        public string? modelo { get; set; }

        [Display(Name = "Año de compra")]
        public int? anio_compra { get; set; }

        [Display(Name = "Costo")]
        public decimal? costo { get; set; }

        [Display(Name = "Vida útil")]
        public int? vida_util { get; set; }

        [Display(Name = "Estado equipo")]
        public int? estado_equipo_id { get; set; }

        [Display(Name = "Estado")]
        public int? estado { get; set; }

    }
}
