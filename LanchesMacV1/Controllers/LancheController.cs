using LanchesMacV1.Models;
using LanchesMacV1.Repository;
using LanchesMacV1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }
        /*
        public IActionResult List()
        {
            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria atual";
            return View(lancheListViewModel);
        }
        */

        public IActionResult List(string categoria)
        {
            string categoriaInterna = categoria;
            IEnumerable<Lanche> lanches;

            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(ordem => ordem.LancheId);
                categoria = "Todos os lanches";
            }
            else
            {
                if(string.Equals("Normal",categoriaInterna, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches.Where(res => res.Categoria.Nome.Equals("Normal"));
                }
                else
                {
                    lanches = _lancheRepository.Lanches.Where(res => res.Categoria.Nome.Equals("Natural"));
                }
                categoriaAtual = categoriaInterna;
            }

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lancheListViewModel);

        }

        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(res => res.LancheId == lancheId);
            if (lanche == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            return View(lanche);

        }



    }
}
