using LanchesMacV1.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Models
{
    public class CarrinhoCompra //Nesta classe precisamos do EF (contexto) e Cookies via session (IServiceProvider)
    {

        private readonly AppDbContext _context; //Injeção de dependência para AppDbContext visando usar o db via EF

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services) //Usa IServiceProvider para acessar o serviços em Startup.cs
        {
            //Define uma session usando o contexto atual e precisa ser inserido em IServiceCollection do Startup.cs.ConfigureServices().
            //? == if, se não houver sessão retornará null, senão retornará a sessão no contexto

            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem um serviço do tipo do nosso contexto (ou seja acessa todos dbs sets do nosso AppDbContext)
            var context = services.GetService<AppDbContext>();

            //obtem/gera o id do nosso carrinho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //imbui a sessão com o id do carrinho
            session.SetString("CarrinhoId", carrinhoId);

            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }

        public void AdicionarAoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(item => item.Lanche.LancheId == lanche.LancheId
            && item.CarrinhoCompraId == CarrinhoCompraId);

            //verifica se o carrinho existe : cria um novo

            if (carrinhoCompraItem == null)
            {// This I'don't know the destination
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };
                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }
            _context.SaveChanges();
        }

        public int RemoverDoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem =
                _context.CarrinhoCompraItens.SingleOrDefault(item => item.Lanche.LancheId == lanche.LancheId
                && item.CarrinhoCompraId == CarrinhoCompraId);

            var quantidadeLocal = 0;

            if (carrinhoCompraItem != null)
            {
                if (carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                    quantidadeLocal = carrinhoCompraItem.Quantidade;
                }
                else
                {
                    _context.CarrinhoCompraItens.Remove(carrinhoCompraItem);
                }

            }
            _context.SaveChanges();

            return quantidadeLocal;

        }
        public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
        {
            return CarrinhoCompraItens ?? //se tiver algo a direita retorna, senão retorna o bloco à esquerda
                (CarrinhoCompraItens =
                _context.CarrinhoCompraItens.Where(carrinhoCompraItem => carrinhoCompraItem.CarrinhoCompraId == CarrinhoCompraId)
                .Include(carrinhoCompraItem => carrinhoCompraItem.Lanche).ToList());
        }

        public void LimparCarrinho()
        {
            var carrinhoItens = _context.CarrinhoCompraItens
                .Where(carrinho => carrinho.CarrinhoCompraId == CarrinhoCompraId);

            _context.CarrinhoCompraItens.RemoveRange(carrinhoItens);

            _context.SaveChanges();
        }

        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.CarrinhoCompraItens.Where(carrinho => carrinho.CarrinhoCompraId == CarrinhoCompraId)
                .Select(cadaItem => cadaItem.Lanche.Preco * cadaItem.Quantidade).Sum();

            return total;
        }
    }

}

