using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebMercadoMVC.Models
{
    [Table("Compras")]
    public class Compra
    {
        [Key]
        [Display(Name = "id:")]
        public int id { get; set; }

        public int clienteid { get; set; }
        [ForeignKey("clienteid")]
        [Display(Name = "Cliente:")]
        public Cliente cliente { get; set; }

        public int produtoid { get; set; }
        [ForeignKey("produtoid")]
        [Display(Name = "Produto:")]
        public Produto produto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Quantidade Requisitada:")]
        public int quantidaderequisitada { get; set; }

    }
}
