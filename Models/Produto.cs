using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebMercadoMVC.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id:")]
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Quantidade Disponível:")]
        public int qtde { get; set; }

        [Required(ErrorMessage = "Campo Obgrigatório")]
        [Display(Name = "Nome:")]
        [StringLength(30)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Preço:")]
        public float preco { get; set; }


    }
}
