using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaProject.ECommerce.Dashboard.Data.ViewModels
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeEntregaRealizada { get; set; }
        public string Endereco { get; set; }
        public EquipeViewModel Equipe { get; set; }
        public ICollection<ProdutoViewModel> Produtos { get; set; }
    }
}
