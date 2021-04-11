using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject.ECommerce.Dashboard.Data.Entities;

namespace WaProject.ECommerce.Dashboard.Data
{
    public class DashboardContext : DbContext
    {
        public DashboardContext(DbContextOptions<DashboardContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipe>().HasMany(equipe => equipe.Pedidos).WithOne(pedido => pedido.Equipe);
            modelBuilder.Entity<Pedido>().HasOne(pedido => pedido.Equipe).WithMany(equipe => equipe.Pedidos);
            modelBuilder.Entity<Pedido>().HasMany(pedido => pedido.Produtos).WithOne(produto => produto.Pedido);
            modelBuilder.Entity<Produto>().HasOne(produto => produto.Pedido).WithMany(pedido => pedido.Produtos);

            var random = new Random();
            int index = 1;

            var equipesFake = new Faker<Equipe>("pt_BR")
                .RuleFor(x => x.Id, y => index++)
                .RuleFor(x => x.Nome, y => y.Name.JobTitle())
                .RuleFor(x => x.Descricao, y => y.Lorem.Text())
                .RuleFor(x => x.PlacaDoVeiculoUltilizado, y => y.Vehicle.Vin());
            List<Equipe> equipes = equipesFake.Generate(5);

            foreach (var equipe in equipes)
            {
                modelBuilder.Entity<Equipe>().HasData(equipe);
            }

            index = 1;
            var pedidosFake = new Faker<Pedido>("pt_BR")
                .RuleFor(x => x.Id, y => index++)
                .RuleFor(x => x.DataDeCriacao, y => y.Date.Recent(90))
                .RuleFor(x => x.DataDeEntregaRealizada, y => y.Date.Recent(90))
                .RuleFor(x => x.Endereco, y => y.Address.StreetAddress());
            List<Pedido> pedidos = pedidosFake.Generate(10);

            foreach(var pedido in pedidos)
            {
                pedido.EquipeId = equipes[random.Next(equipes.Count)].Id;
                modelBuilder.Entity<Pedido>().HasData(pedido);
            }

            index = 1;
            var produtosFake = new Faker<Produto>("pt_BR")
                .RuleFor(x => x.Id, y => index++)
                .RuleFor(x => x.Nome, y => y.Name.FullName())
                .RuleFor(x => x.Descricao, y => y.Lorem.Text())
                .RuleFor(x => x.Valor, y => y.Finance.Amount());
            List<Produto> produtos = produtosFake.Generate(30);

            foreach(var produto in produtos)
            {
                produto.PedidoId = pedidos[random.Next(pedidos.Count)].Id;
                modelBuilder.Entity<Produto>().HasData(produto);
            }

        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
