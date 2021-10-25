using LanchesMacV1.Models;
using LanchesMacV1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            var items = _carrinhoCompra.GetCarrinhoCompraItens();
            //para testar! remova a linha 24 antes de prosseguir as implementações
            //var items = new List<CarrinhoCompraItem>() { new CarrinhoCompraItem(), new CarrinhoCompraItem() };
            _carrinhoCompra.CarrinhoCompraItens = items;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(carrinhoCompraVM);
        }
    }
}
