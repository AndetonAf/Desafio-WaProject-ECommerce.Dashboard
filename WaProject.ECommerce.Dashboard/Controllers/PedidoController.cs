using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject.ECommerce.Dashboard.Data;
using WaProject.ECommerce.Dashboard.Data.Repository;
using WaProject.ECommerce.Dashboard.Data.ViewModels;

namespace WaProject.ECommerce.Dashboard.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository pedidoRepository;

        public PedidoController(DashboardContext context)
        {
            pedidoRepository = new PedidoRepository(context);
        }

        [HttpGet]
        public Paginacao ObterTodos(int offset = 0, int limit = 5)
        {
            Paginacao paginacao = new Paginacao
            {
                Offset = offset,
                Limit = limit
            };

            paginacao.Data = pedidoRepository.ObterPedidos(paginacao).Select(pedido => (PedidoViewModel)pedido).ToList();
            return paginacao;
        }
    }
}
