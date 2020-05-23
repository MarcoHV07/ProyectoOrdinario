

namespace MaquinaTortillera.data
{
    using System.ComponentModel.DataAnnotations;
    public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength (20)]
        public string Tamaño { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string MasaN { get; set; }
        [Required]
        public string Sabor { get; set; }
        [Required]
        public double Kilos { get; set; }
        [Required]
          public double MasaU { get; set; }
        [Required]
       public string Estado { get; set; }
        [Required]
        [StringLength(150)]
        public string Notas { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
    }
    
}
