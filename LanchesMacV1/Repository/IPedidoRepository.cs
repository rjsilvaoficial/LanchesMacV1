using LanchesMacV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Repository
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);


    }
}
