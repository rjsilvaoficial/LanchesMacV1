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
        //[BindNever]
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(20)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome")]
        [StringLength(20)]
        public string Sobrenome { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Informe o endereço")]
        [StringLength(100)]
        public string Endereco1 { get; set; }

        [Display(Name = "Complemento")]
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
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        [StringLength(50)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "O email não possui um formato correto")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [Column(TypeName = "decimal(18,2)")]
        [ScaffoldColumn(false)]
        public decimal PedidoTotal { get; set; }

        [Display(Name = "Data e horário do recebimento do pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "(0: dd/MM/yyyy hh:mm)", ApplyFormatInEditMode = true)]
        public DateTime PedidoEnviado { get; set; }

        [Display(Name = "Data e horário da entrega do pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "(0: dd/MM/yyyy hh:mm)", ApplyFormatInEditMode = true)]
        public DateTime? PedidoEntregueEm { get; set; }
        public List<PedidoDetalhe> PedidoItens { get; set; }

    }
}
