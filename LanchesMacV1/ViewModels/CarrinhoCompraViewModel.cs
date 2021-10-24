using LanchesMacV1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.ViewModels
{
    public class CarrinhoCompraViewModel
    {
        public CarrinhoCompra CarrinhoCompra { get; set; }
        [Column(TypeName = "decimal(18,2)")]  //o annotation Column, está disponível em DataAnnotations.Schema
        public decimal CarrinhoCompraTotal { get; set; }
    }
}
