using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMercadoMVC.Models
{
    [Table("Ofertas")]
    public class Oferta
    {
        [Key]
        [Display(Name = "id:")]
        public int id { get; set; }

        public int produtoid { get; set; }
        [ForeignKey("produtoid")]
        [Display(Name = "Produto:")]
        public Produto produto { get; set; }

        [Required(ErrorMessage = "campo data é obrigatório")]
        [Display(Name = "Oferta:")]
        public float oferta { get; set; }

        [Required(ErrorMessage = "campo data é obrigatório")]
        [Display(Name = "Data da Oferta:")]
        public DateTime dataoferta { get; set; }
    }
}
