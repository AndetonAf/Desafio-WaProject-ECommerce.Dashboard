using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WaProject.ECommerce.Dashboard.Data.Migrations
{
    public partial class CriacaoDasTabelasPedidoEquipeEProdutoESeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlacaDoVeiculoUltilizado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipeId = table.Column<int>(type: "int", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeEntregaRealizada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Equipes_EquipeId",
                        column: x => x.EquipeId,
                        principalTable: "Equipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Equipes",
                columns: new[] { "Id", "Descricao", "Nome", "PlacaDoVeiculoUltilizado" },
                values: new object[,]
                {
                    { 1, "et", "Dynamic Paradigm Coordinator", "SEMEF4IAQNJT69130" },
                    { 2, "Non deleniti corrupti sunt.", "Lead Identity Technician", "OK8V6JTAILD693697" },
                    { 3, "Minima vel ut explicabo quasi quibusdam deserunt quibusdam at. Explicabo pariatur assumenda vel est quo inventore dolorem error. Ut praesentium ducimus nesciunt assumenda soluta corrupti aspernatur sint corporis. Quis amet est quia minima voluptatem voluptatum quia architecto.", "District Identity Orchestrator", "KQZJEQCS8QHG43408" },
                    { 4, "Voluptas reprehenderit nemo dolores debitis omnis.", "Regional Data Assistant", "XTN16EKKZHJ853650" },
                    { 5, "Vero amet aut consequatur repudiandae autem earum iure.", "Human Mobility Supervisor", "WR5SR3VFMLBB65744" }
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "Id", "DataDeCriacao", "DataDeEntregaRealizada", "Endereco", "EquipeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 26, 9, 34, 13, 655, DateTimeKind.Local).AddTicks(928), new DateTime(2021, 3, 26, 8, 54, 4, 174, DateTimeKind.Local).AddTicks(5033), "3462 Silva Alameda", 1 },
                    { 3, new DateTime(2021, 2, 25, 6, 44, 52, 476, DateTimeKind.Local).AddTicks(9628), new DateTime(2021, 1, 29, 9, 53, 27, 405, DateTimeKind.Local).AddTicks(6993), "02190 Franco Travessa", 1 },
                    { 5, new DateTime(2021, 2, 6, 1, 5, 24, 527, DateTimeKind.Local).AddTicks(6444), new DateTime(2021, 3, 27, 21, 48, 7, 38, DateTimeKind.Local).AddTicks(8391), "22833 Souza Marginal", 1 },
                    { 8, new DateTime(2021, 2, 24, 21, 4, 19, 743, DateTimeKind.Local).AddTicks(8390), new DateTime(2021, 2, 18, 7, 46, 58, 275, DateTimeKind.Local).AddTicks(3697), "77266 Davi Lucca Travessa", 2 },
                    { 10, new DateTime(2021, 2, 25, 22, 23, 10, 812, DateTimeKind.Local).AddTicks(6860), new DateTime(2021, 2, 11, 22, 4, 12, 273, DateTimeKind.Local).AddTicks(6191), "277 Karla Rua", 2 },
                    { 6, new DateTime(2021, 3, 16, 10, 53, 35, 287, DateTimeKind.Local).AddTicks(5424), new DateTime(2021, 3, 17, 20, 33, 41, 654, DateTimeKind.Local).AddTicks(9132), "430 Fabiano Avenida", 4 },
                    { 2, new DateTime(2021, 4, 4, 7, 8, 29, 958, DateTimeKind.Local).AddTicks(4112), new DateTime(2021, 2, 15, 1, 32, 46, 668, DateTimeKind.Local).AddTicks(9903), "817 Costa Rodovia", 5 },
                    { 4, new DateTime(2021, 4, 3, 14, 20, 16, 726, DateTimeKind.Local).AddTicks(3355), new DateTime(2021, 4, 8, 3, 24, 27, 592, DateTimeKind.Local).AddTicks(5357), "30418 Silva Marginal", 5 },
                    { 7, new DateTime(2021, 2, 22, 8, 3, 29, 770, DateTimeKind.Local).AddTicks(3569), new DateTime(2021, 2, 15, 6, 0, 36, 88, DateTimeKind.Local).AddTicks(7238), "77065 Oliveira Rua", 5 },
                    { 9, new DateTime(2021, 4, 9, 10, 32, 52, 751, DateTimeKind.Local).AddTicks(6755), new DateTime(2021, 2, 13, 16, 35, 27, 781, DateTimeKind.Local).AddTicks(3421), "65668 Ofélia Avenida", 5 }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "PedidoId", "Valor" },
                values: new object[,]
                {
                    { 2, "Nesciunt ut minus expedita et harum non nostrum sunt amet. Molestiae consequatur voluptatem molestias dolores et. Tempore delectus suscipit enim.", "Isabella Macedo", 1, 445.35m },
                    { 21, "Quae aut atque. Sequi sapiente quia eos optio tempora tempore quasi. Ullam optio exercitationem cumque nostrum.", "Maria Eduarda Xavier", 9, 717.62m },
                    { 19, "Eaque non et beatae.\nProvident rerum fugit et et rerum consectetur esse amet.", "Sirineu Pereira", 9, 647.57m },
                    { 6, "Et quis provident in voluptas id iure tempora ex quis.\nCommodi doloribus voluptatum facilis ex accusantium.\nConsequatur et assumenda.\nDoloribus et et ut dolor illo.", "Gúbio Barros", 9, 320.15m },
                    { 3, "Ut aut voluptate.\nEt enim aut eos dolor est tenetur tempore.\nUt odit quia dolore.\nLaboriosam consectetur molestiae.\nEt sed adipisci veritatis quidem.", "Giovanna Carvalho", 9, 887.88m },
                    { 12, "Quibusdam praesentium minus quia exercitationem.", "Deneval Martins", 7, 454.75m },
                    { 11, "id", "Gustavo Albuquerque", 7, 605.69m },
                    { 10, "Fugit aut cupiditate accusamus eveniet laudantium unde. Quia iste tempora. Nulla eveniet aspernatur sequi odit quo blanditiis expedita explicabo. Consequatur voluptas ut natus. Fuga dolores et quas sit animi qui iste.", "Lorenzo Macedo", 7, 794.87m },
                    { 25, "voluptas", "Isabella Saraiva", 4, 10.55m },
                    { 20, "Quia perspiciatis cum dolor molestiae atque ut. Architecto iure maiores in laudantium voluptatem tempora quia qui. Deserunt dolorum voluptatum aut dolore reiciendis atque est adipisci. Velit qui nihil omnis ad est accusantium dolores aliquam.", "Lívia Barros", 4, 87.15m },
                    { 14, "Ea nobis autem soluta et vel quis.\nOfficia perferendis reprehenderit.\nQuos laboriosam reiciendis cum fugiat provident optio laborum enim adipisci.\nNecessitatibus molestias reprehenderit exercitationem.\nEst quos laudantium maxime.", "Miguel Albuquerque", 4, 507.50m },
                    { 7, "Aut vitae cum eius esse laudantium praesentium ut placeat.\nNatus qui saepe cumque non corporis.\nOdio maxime porro quia aut.", "Ricardo Nogueira", 4, 381.71m },
                    { 4, "Debitis accusantium praesentium.\nExpedita exercitationem optio dolor facilis a enim modi repellat.\nEt dolorem quia sunt explicabo quia velit fuga a.", "Benício Macedo", 4, 613.61m },
                    { 24, "Pariatur dolorem ut ex et ratione sed.\nFacilis sed consequuntur harum et facilis.\nEt natus vero quis.\nA et et.", "Larissa Franco", 2, 728.95m },
                    { 18, "nulla", "Talita Pereira", 2, 321.19m },
                    { 22, "At labore minus quasi. Sed voluptas et reprehenderit voluptas sed aspernatur alias. Ipsa eos officiis accusamus est omnis id ut minus adipisci.", "Manuela Braga", 6, 556.24m },
                    { 26, "Maxime quis esse omnis est est ullam reiciendis.", "Raul Costa", 10, 172.35m },
                    { 16, "quam", "Enzo Gabriel Batista", 8, 849.20m },
                    { 1, "Aut sit culpa. Veniam voluptates quae tempora aperiam. Architecto non hic facere doloribus ab eos rerum maiores impedit. Temporibus laborum expedita veniam dolores ea repudiandae. Vero corporis aut consectetur cum. Est earum ut nisi recusandae.", "Norberto Costa", 8, 442.63m },
                    { 28, "sapiente", "Raul Carvalho", 5, 455.17m },
                    { 9, "Eaque consequuntur dignissimos ut rerum placeat. Cumque doloremque delectus et cupiditate consequatur in. Repellendus enim fugiat et minima. Rerum aut necessitatibus consequatur qui et tempore animi officiis vero. Et voluptatem corporis eius reiciendis molestias animi corporis et nemo.", "Paulo Melo", 5, 449.21m },
                    { 5, "Voluptas dolor aspernatur.\nRerum ullam debitis est nisi deserunt quisquam.\nPerferendis dolor aliquid tempora reiciendis adipisci ad quia.\nEst nemo blanditiis non et aliquam quasi nulla.\nAut minus accusantium sunt aut quia ipsum.", "Davi Lucca Costa", 5, 658.55m },
                    { 30, "quos", "Enzo Reis", 3, 932.45m },
                    { 13, "Repellat omnis harum suscipit consequatur molestiae mollitia vitae ab non. Ducimus laboriosam corporis aut. Eligendi at illo. Voluptatem iure corrupti odio aspernatur et esse sed temporibus eum.", "Maria Luiza Moraes", 3, 486.64m },
                    { 8, "Et sint dolores vel nesciunt. Libero natus cum consequatur. Nisi nisi quam quod unde illo adipisci aut. Non perferendis excepturi ex voluptates corrupti.", "Tertuliano Barros", 3, 591.14m },
                    { 29, "Dolorum itaque voluptatem molestiae minima esse vel iste quisquam itaque.\nAd qui aspernatur officiis dicta maiores quia repellendus pariatur.\nEst adipisci est iure maxime alias accusamus odit.", "Eduarda Batista", 1, 190.41m },
                    { 17, "At consequatur aut qui eveniet amet.\nNeque dignissimos et ipsum tempora.\nVoluptatem laboriosam aspernatur omnis facilis qui minima.\nDelectus et laudantium ut magnam mollitia pariatur.\nSequi ea repellat soluta nulla.", "Beatriz Moraes", 1, 369.44m },
                    { 15, "inventore", "Deneval Saraiva", 1, 370.51m },
                    { 23, "Optio vitae libero ex debitis repudiandae. Aliquam modi culpa eveniet. Soluta ducimus aspernatur. Exercitationem impedit dolore vero est voluptatum labore.", "Paula Moreira", 9, 659.48m },
                    { 27, "modi", "Maria Clara Pereira", 9, 109.14m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EquipeId",
                table: "Pedidos",
                column: "EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Equipes");
        }
    }
}
