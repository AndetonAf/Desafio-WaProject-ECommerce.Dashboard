using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaProject.ECommerce.Dashboard.Data.ViewModels;

namespace WaProject.ECommerce.Dashboard.Data.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int EquipeId { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeEntregaRealizada { get; set; }
        public string Endereco { get; set; }
        public virtual Equipe Equipe { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

        public static explicit operator PedidoViewModel(Pedido pedido)
        {
            return new PedidoViewModel
            {
                Id = pedido.Id,
                DataDeCriacao = pedido.DataDeCriacao,
                DataDeEntregaRealizada = pedido.DataDeEntregaRealizada,
                Endereco = pedido.Endereco,
                Equipe = (EquipeViewModel)pedido.Equipe,
                Produtos = pedido.Produtos.Select(x => (ProdutoViewModel)x).ToList()
            };
        }
    }

}
