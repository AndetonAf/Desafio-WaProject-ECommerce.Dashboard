﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaProject.ECommerce.Dashboard.Data;

namespace WaProject.ECommerce.Dashboard.Data.Migrations
{
    [DbContext(typeof(DashboardContext))]
    [Migration("20210410235100_CriacaoDasTabelasPedidoEquipeEProdutoESeeds")]
    partial class CriacaoDasTabelasPedidoEquipeEProdutoESeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WaProject.ECommerce.Dashboard.Data.Entities.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlacaDoVeiculoUltilizado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "et",
                            Nome = "Dynamic Paradigm Coordinator",
                            PlacaDoVeiculoUltilizado = "SEMEF4IAQNJT69130"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Non deleniti corrupti sunt.",
                            Nome = "Lead Identity Technician",
                            PlacaDoVeiculoUltilizado = "OK8V6JTAILD693697"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Minima vel ut explicabo quasi quibusdam deserunt quibusdam at. Explicabo pariatur assumenda vel est quo inventore dolorem error. Ut praesentium ducimus nesciunt assumenda soluta corrupti aspernatur sint corporis. Quis amet est quia minima voluptatem voluptatum quia architecto.",
                            Nome = "District Identity Orchestrator",
                            PlacaDoVeiculoUltilizado = "KQZJEQCS8QHG43408"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Voluptas reprehenderit nemo dolores debitis omnis.",
                            Nome = "Regional Data Assistant",
                            PlacaDoVeiculoUltilizado = "XTN16EKKZHJ853650"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Vero amet aut consequatur repudiandae autem earum iure.",
                            Nome = "Human Mobility Supervisor",
                            PlacaDoVeiculoUltilizado = "WR5SR3VFMLBB65744"
                        });
                });

            modelBuilder.Entity("WaProject.ECommerce.Dashboard.Data.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeEntregaRealizada")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipeId");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataDeCriacao = new DateTime(2021, 1, 26, 9, 34, 13, 655, DateTimeKind.Local).AddTicks(928),
                            DataDeEntregaRealizada = new DateTime(2021, 3, 26, 8, 54, 4, 174, DateTimeKind.Local).AddTicks(5033),
                            Endereco = "3462 Silva Alameda",
                            EquipeId = 1
                        },
                        new
                        {
                            Id = 2,
                            DataDeCriacao = new DateTime(2021, 4, 4, 7, 8, 29, 958, DateTimeKind.Local).AddTicks(4112),
                            DataDeEntregaRealizada = new DateTime(2021, 2, 15, 1, 32, 46, 668, DateTimeKind.Local).AddTicks(9903),
                            Endereco = "817 Costa Rodovia",
                            EquipeId = 5
                        },
                        new
                        {
                            Id = 3,
                            DataDeCriacao = new DateTime(2021, 2, 25, 6, 44, 52, 476, DateTimeKind.Local).AddTicks(9628),
                            DataDeEntregaRealizada = new DateTime(2021, 1, 29, 9, 53, 27, 405, DateTimeKind.Local).AddTicks(6993),
                            Endereco = "02190 Franco Travessa",
                            EquipeId = 1
                        },
                        new
                        {
                            Id = 4,
                            DataDeCriacao = new DateTime(2021, 4, 3, 14, 20, 16, 726, DateTimeKind.Local).AddTicks(3355),
                            DataDeEntregaRealizada = new DateTime(2021, 4, 8, 3, 24, 27, 592, DateTimeKind.Local).AddTicks(5357),
                            Endereco = "30418 Silva Marginal",
                            EquipeId = 5
                        },
                        new
                        {
                            Id = 5,
                            DataDeCriacao = new DateTime(2021, 2, 6, 1, 5, 24, 527, DateTimeKind.Local).AddTicks(6444),
                            DataDeEntregaRealizada = new DateTime(2021, 3, 27, 21, 48, 7, 38, DateTimeKind.Local).AddTicks(8391),
                            Endereco = "22833 Souza Marginal",
                            EquipeId = 1
                        },
                        new
                        {
                            Id = 6,
                            DataDeCriacao = new DateTime(2021, 3, 16, 10, 53, 35, 287, DateTimeKind.Local).AddTicks(5424),
                            DataDeEntregaRealizada = new DateTime(2021, 3, 17, 20, 33, 41, 654, DateTimeKind.Local).AddTicks(9132),
                            Endereco = "430 Fabiano Avenida",
                            EquipeId = 4
                        },
                        new
                        {
                            Id = 7,
                            DataDeCriacao = new DateTime(2021, 2, 22, 8, 3, 29, 770, DateTimeKind.Local).AddTicks(3569),
                            DataDeEntregaRealizada = new DateTime(2021, 2, 15, 6, 0, 36, 88, DateTimeKind.Local).AddTicks(7238),
                            Endereco = "77065 Oliveira Rua",
                            EquipeId = 5
                        },
                        new
                        {
                            Id = 8,
                            DataDeCriacao = new DateTime(2021, 2, 24, 21, 4, 19, 743, DateTimeKind.Local).AddTicks(8390),
                            DataDeEntregaRealizada = new DateTime(2021, 2, 18, 7, 46, 58, 275, DateTimeKind.Local).AddTicks(3697),
                            Endereco = "77266 Davi Lucca Travessa",
                            EquipeId = 2
                        },
                        new
                        {
                            Id = 9,
                            DataDeCriacao = new DateTime(2021, 4, 9, 10, 32, 52, 751, DateTimeKind.Local).AddTicks(6755),
                            DataDeEntregaRealizada = new DateTime(2021, 2, 13, 16, 35, 27, 781, DateTimeKind.Local).AddTicks(3421),
                            Endereco = "65668 Ofélia Avenida",
                            EquipeId = 5
                        },
                        new
                        {
                            Id = 10,
                            DataDeCriacao = new DateTime(2021, 2, 25, 22, 23, 10, 812, DateTimeKind.Local).AddTicks(6860),
                            DataDeEntregaRealizada = new DateTime(2021, 2, 11, 22, 4, 12, 273, DateTimeKind.Local).AddTicks(6191),
                            Endereco = "277 Karla Rua",
                            EquipeId = 2
                        });
                });

            modelBuilder.Entity("WaProject.ECommerce.Dashboard.Data.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Aut sit culpa. Veniam voluptates quae tempora aperiam. Architecto non hic facere doloribus ab eos rerum maiores impedit. Temporibus laborum expedita veniam dolores ea repudiandae. Vero corporis aut consectetur cum. Est earum ut nisi recusandae.",
                            Nome = "Norberto Costa",
                            PedidoId = 8,
                            Valor = 442.63m
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Nesciunt ut minus expedita et harum non nostrum sunt amet. Molestiae consequatur voluptatem molestias dolores et. Tempore delectus suscipit enim.",
                            Nome = "Isabella Macedo",
                            PedidoId = 1,
                            Valor = 445.35m
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Ut aut voluptate.\nEt enim aut eos dolor est tenetur tempore.\nUt odit quia dolore.\nLaboriosam consectetur molestiae.\nEt sed adipisci veritatis quidem.",
                            Nome = "Giovanna Carvalho",
                            PedidoId = 9,
                            Valor = 887.88m
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Debitis accusantium praesentium.\nExpedita exercitationem optio dolor facilis a enim modi repellat.\nEt dolorem quia sunt explicabo quia velit fuga a.",
                            Nome = "Benício Macedo",
                            PedidoId = 4,
                            Valor = 613.61m
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Voluptas dolor aspernatur.\nRerum ullam debitis est nisi deserunt quisquam.\nPerferendis dolor aliquid tempora reiciendis adipisci ad quia.\nEst nemo blanditiis non et aliquam quasi nulla.\nAut minus accusantium sunt aut quia ipsum.",
                            Nome = "Davi Lucca Costa",
                            PedidoId = 5,
                            Valor = 658.55m
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "Et quis provident in voluptas id iure tempora ex quis.\nCommodi doloribus voluptatum facilis ex accusantium.\nConsequatur et assumenda.\nDoloribus et et ut dolor illo.",
                            Nome = "Gúbio Barros",
                            PedidoId = 9,
                            Valor = 320.15m
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "Aut vitae cum eius esse laudantium praesentium ut placeat.\nNatus qui saepe cumque non corporis.\nOdio maxime porro quia aut.",
                            Nome = "Ricardo Nogueira",
                            PedidoId = 4,
                            Valor = 381.71m
                        },
                        new
                        {
                            Id = 8,
                            Descricao = "Et sint dolores vel nesciunt. Libero natus cum consequatur. Nisi nisi quam quod unde illo adipisci aut. Non perferendis excepturi ex voluptates corrupti.",
                            Nome = "Tertuliano Barros",
                            PedidoId = 3,
                            Valor = 591.14m
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "Eaque consequuntur dignissimos ut rerum placeat. Cumque doloremque delectus et cupiditate consequatur in. Repellendus enim fugiat et minima. Rerum aut necessitatibus consequatur qui et tempore animi officiis vero. Et voluptatem corporis eius reiciendis molestias animi corporis et nemo.",
                            Nome = "Paulo Melo",
                            PedidoId = 5,
                            Valor = 449.21m
                        },
                        new
                        {
                            Id = 10,
                            Descricao = "Fugit aut cupiditate accusamus eveniet laudantium unde. Quia iste tempora. Nulla eveniet aspernatur sequi odit quo blanditiis expedita explicabo. Consequatur voluptas ut natus. Fuga dolores et quas sit animi qui iste.",
                            Nome = "Lorenzo Macedo",
                            PedidoId = 7,
                            Valor = 794.87m
                        },
                        new
                        {
                            Id = 11,
                            Descricao = "id",
                            Nome = "Gustavo Albuquerque",
                            PedidoId = 7,
                            Valor = 605.69m
                        },
                        new
                        {
                            Id = 12,
                            Descricao = "Quibusdam praesentium minus quia exercitationem.",
                            Nome = "Deneval Martins",
                            PedidoId = 7,
                            Valor = 454.75m
                        },
                        new
                        {
                            Id = 13,
                            Descricao = "Repellat omnis harum suscipit consequatur molestiae mollitia vitae ab non. Ducimus laboriosam corporis aut. Eligendi at illo. Voluptatem iure corrupti odio aspernatur et esse sed temporibus eum.",
                            Nome = "Maria Luiza Moraes",
                            PedidoId = 3,
                            Valor = 486.64m
                        },
                        new
                        {
                            Id = 14,
                            Descricao = "Ea nobis autem soluta et vel quis.\nOfficia perferendis reprehenderit.\nQuos laboriosam reiciendis cum fugiat provident optio laborum enim adipisci.\nNecessitatibus molestias reprehenderit exercitationem.\nEst quos laudantium maxime.",
                            Nome = "Miguel Albuquerque",
                            PedidoId = 4,
                            Valor = 507.50m
                        },
                        new
                        {
                            Id = 15,
                            Descricao = "inventore",
                            Nome = "Deneval Saraiva",
                            PedidoId = 1,
                            Valor = 370.51m
                        },
                        new
                        {
                            Id = 16,
                            Descricao = "quam",
                            Nome = "Enzo Gabriel Batista",
                            PedidoId = 8,
                            Valor = 849.20m
                        },
                        new
                        {
                            Id = 17,
                            Descricao = "At consequatur aut qui eveniet amet.\nNeque dignissimos et ipsum tempora.\nVoluptatem laboriosam aspernatur omnis facilis qui minima.\nDelectus et laudantium ut magnam mollitia pariatur.\nSequi ea repellat soluta nulla.",
                            Nome = "Beatriz Moraes",
                            PedidoId = 1,
                            Valor = 369.44m
                        },
                        new
                        {
                            Id = 18,
                            Descricao = "nulla",
                            Nome = "Talita Pereira",
                            PedidoId = 2,
                            Valor = 321.19m
                        },
                        new
                        {
                            Id = 19,
                            Descricao = "Eaque non et beatae.\nProvident rerum fugit et et rerum consectetur esse amet.",
                            Nome = "Sirineu Pereira",
                            PedidoId = 9,
                            Valor = 647.57m
                        },
                        new
                        {
                            Id = 20,
                            Descricao = "Quia perspiciatis cum dolor molestiae atque ut. Architecto iure maiores in laudantium voluptatem tempora quia qui. Deserunt dolorum voluptatum aut dolore reiciendis atque est adipisci. Velit qui nihil omnis ad est accusantium dolores aliquam.",
                            Nome = "Lívia Barros",
                            PedidoId = 4,
                            Valor = 87.15m
                        },
                        new
                        {
                            Id = 21,
                            Descricao = "Quae aut atque. Sequi sapiente quia eos optio tempora tempore quasi. Ullam optio exercitationem cumque nostrum.",
                            Nome = "Maria Eduarda Xavier",
                            PedidoId = 9,
                            Valor = 717.62m
                        },
                        new
                        {
                            Id = 22,
                            Descricao = "At labore minus quasi. Sed voluptas et reprehenderit voluptas sed aspernatur alias. Ipsa eos officiis accusamus est omnis id ut minus adipisci.",
                            Nome = "Manuela Braga",
                            PedidoId = 6,
                            Valor = 556.24m
                        },
                        new
                        {
                            Id = 23,
                            Descricao = "Optio vitae libero ex debitis repudiandae. Aliquam modi culpa eveniet. Soluta ducimus aspernatur. Exercitationem impedit dolore vero est voluptatum labore.",
                            Nome = "Paula Moreira",
                            PedidoId = 9,
                            Valor = 659.48m
                        },
                        new
                        {
                            Id = 24,
                            Descricao = "Pariatur dolorem ut ex et ratione sed.\nFacilis sed consequuntur harum et facilis.\nEt natus vero quis.\nA et et.",
                            Nome = "Larissa Franco",
                            PedidoId = 2,
                            Valor = 728.95m
                        },
                        new
                        {
                            Id = 25,
                            Descricao = "voluptas",
                            Nome = "Isabella Saraiva",
                            PedidoId = 4,
                            Valor = 10.55m
                        },
                        new
                        {
                            Id = 26,
                            Descricao = "Maxime quis esse omnis est est ullam reiciendis.",
                            Nome = "Raul Costa",
                            PedidoId = 10,
                            Valor = 172.35m
                        },
                        new
                        {
                            Id = 27,
                            Descricao = "modi",
                            Nome = "Maria Clara Pereira",
                            PedidoId = 9,
                            Valor = 109.14m
                        },
                        new
                        {
                            Id = 28,
                            Descricao = "sapiente",
                            Nome = "Raul Carvalho",
                            PedidoId = 5,
                            Valor = 455.17m
                        },
                        new
                        {
                            Id = 29,
                            Descricao = "Dolorum itaque voluptatem molestiae minima esse vel iste quisquam itaque.\nAd qui aspernatur officiis dicta maiores quia repellendus pariatur.\nEst adipisci est iure maxime alias accusamus odit.",
                            Nome = "Eduarda Batista",
                            PedidoId = 1,
                            Valor = 190.41m
                        },
                        new
                        {
                            Id = 30,
                            Descricao = "quos",
                            Nome = "Enzo Reis",
                            PedidoId = 3,
                            Valor = 932.45m
                        });
                });

            modelBuilder.Entity("WaProject.ECommerce.Dashboard.Data.Entities.Pedido", b =>
                {
                    b.HasOne("WaProject.ECommerce.Dashboard.Data.Entities.Equipe", "Equipe")
                        .WithMany("Pedidos")
                        .HasForeignKey("EquipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("WaProject.ECommerce.Dashboard.Data.Entities.Produto", b =>
                {
                    b.HasOne("WaProject.ECommerce.Dashboard.Data.Entities.Pedido", "Pedido")
                        .WithMany("Produtos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("WaProject.ECommerce.Dashboard.Data.Entities.Equipe", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("WaProject.ECommerce.Dashboard.Data.Entities.Pedido", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}