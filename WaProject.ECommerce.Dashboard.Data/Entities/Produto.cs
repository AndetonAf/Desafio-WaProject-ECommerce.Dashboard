using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaProject.ECommerce.Dashboard.Data.ViewModels;

namespace WaProject.ECommerce.Dashboard.Data.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public virtual Pedido Pedido { get; set; }

        public static explicit operator ProdutoViewModel(Produto produto)
        {
            return new ProdutoViewModel
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Valor = produto.Valor
            };
        }
    }
}
