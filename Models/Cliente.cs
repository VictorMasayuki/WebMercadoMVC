using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebMercadoMVC.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id:")]
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Obgrigatório")]
        [Display(Name = "Nome:")]
        [StringLength(30)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Obgrigatório")]
        [Display(Name = "Email:")]
        [StringLength(30)]
        public string email { get; set; }
    }
}
