using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Models
{
    public class Pedido
    {
        [BindNever]
        public int PedidoId { get; set; }

        [Required(ErrorMessage ="Informe o nome")]
        [StringLength(20)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome")]
        [StringLength(20)]
        public string Sobrenome { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Informe o endereço")]
        [StringLength(100)]
        public string Endereco1 { get; set; }

        [Display(Name ="Complemento")]
        [Required(ErrorMessage = "Informe o complemento")]
        [StringLength(100)]
        public string Endereco2 { get; set; }

        [Required(ErrorMessage = "Informe o cep")]
        [StringLength(10)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o estado")]
        [StringLength(30)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe a cidade")]
        [StringLength(30)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o telefone")]
        [StringLength(30)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [Column(TypeName = "decimal(18,2)")]
        [ScaffoldColumn(false)]
        public decimal PedidoTotal { get; set; }
        public DateTime PedidoEnviado { get; set; }
        public List<PedidoDetalhe> PedidoItens{ get; set; }

    }
}
