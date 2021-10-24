using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [Required]
        [StringLength(250)]
        public string DescricaoDetalhada { get; set; }
        [Column(TypeName = "decimal(18,2)")]  //o annotation Column, está disponível em DataAnnotations.Schema
        public decimal Preco { get; set; }
        [StringLength(200)]
        public string ImagemUrl { get; set; }
        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; } //miniatura do lanche

        public bool IsLanchePreferido { get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
