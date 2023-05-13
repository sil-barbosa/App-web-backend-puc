using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_web_backend_puc.Models
{
    [Table("Relatorios")]
    public class Relatorio
    {
        [Key]
        public string Produto { get; set; }
        public string Venda { get; set; }
        public string Estoque { get; set; }

        [Required(ErrorMessage ="Obrigatório informar senha!")]
        public int Senha{ get; set; }
    }
}
