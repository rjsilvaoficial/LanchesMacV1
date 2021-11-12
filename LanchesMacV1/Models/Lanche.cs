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
        [Display(Name = "Descrição curta")]
        public string DescricaoCurta { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name ="Descrição detalhada")]
        public string DescricaoDetalhada { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]  //o annotation Column, está disponível em DataAnnotations.Schema
        public decimal Preco { get; set; }

        [StringLength(200)]
        [Display(Name = "Link da imagem principal")]
        public string ImagemUrl { get; set; }
        [StringLength(200)]

        [Display(Name = "Link da imagem miniatura")]
        public string ImagemThumbnailUrl { get; set; } //miniatura do lanche

        [Display(Name = "Lanche é preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Temos em estoque?")]
        public bool EmEstoque { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
