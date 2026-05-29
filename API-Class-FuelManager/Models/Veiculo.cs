using System.ComponentModel.DataAnnotations;

namespace API_Class_FuelManager.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public int AnoFabricacao { get; set; }
        [Required]
        public int AnoModelo { get; set; }

    }
}
