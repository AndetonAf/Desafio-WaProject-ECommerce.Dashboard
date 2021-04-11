using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaProject.ECommerce.Dashboard.Data.Entities;
using WaProject.ECommerce.Dashboard.Data.ViewModels;

namespace WaProject.ECommerce.Dashboard.Data.Repository
{
    public class PedidoRepository
    {
        private readonly DashboardContext _context;

        public PedidoRepository(DashboardContext context)
        {
            _context = context;
        }

        public List<Pedido> ObterPedidos(Paginacao paginacao)
        {
            var pedidos = _context.Pedidos.Include(x => x.Produtos).Include(x => x.Equipe);
            paginacao.Total = pedidos.Count();
            return pedidos.Skip(paginacao.Offset).Take(paginacao.Limit).OrderBy(x => x.DataDeCriacao).ToList();
        }

    }
}
