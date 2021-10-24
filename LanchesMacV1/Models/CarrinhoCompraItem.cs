using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Models
{
    public class CarrinhoCompraItem //essa entidade terá um ou mais objetos atrelados a um CarrinhoCompra
    {
        public int CarrinhoCompraItemId { get; set; } // serve para que o CarrinhoCompra identifique cada objeto deste

        public Lanche Lanche { get; set; }

        public int Quantidade { get; set; }

        [StringLength(200)]
        public string CarrinhoCompraId { get; set; } //Teremos vários CarrinhosCompraItem para cada CarrinhoCompra * para 1

    }
}
