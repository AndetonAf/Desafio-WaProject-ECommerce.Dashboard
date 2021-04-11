using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaProject.ECommerce.Dashboard.Data.ViewModels;

namespace WaProject.ECommerce.Dashboard.Data.Entities
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string PlacaDoVeiculoUltilizado { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public static explicit operator EquipeViewModel(Equipe equipe)
        {
            return new EquipeViewModel
            {
                Id = equipe.Id,
                Nome = equipe.Nome,
                Descricao = equipe.Descricao,
                PlacaDoVeiculoUltilizado = equipe.PlacaDoVeiculoUltilizado
            };
        }
    }
}
