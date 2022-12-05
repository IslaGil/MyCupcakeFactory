using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCupcakeFactory.Data.Migradion
{
    public partial class SecCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tamanho",
                table: "Categoria",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Confeiteiro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confeiteiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereço",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereço", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entregador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategoria = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: true),
                    IdConfeiteiro = table.Column<int>(nullable: false),
                    ConfeiteiroId = table.Column<int>(nullable: true),
                    Valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Confeiteiro_ConfeiteiroId",
                        column: x => x.ConfeiteiroId,
                        principalTable: "Confeiteiro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    IdEndereço = table.Column<int>(nullable: false),
                    EndereçoId = table.Column<int>(nullable: true),
                    CPF = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereço_EndereçoId",
                        column: x => x.EndereçoId,
                        principalTable: "Endereço",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    FormaDePagamento = table.Column<string>(nullable: true),
                    IdConfeiteiro = table.Column<int>(nullable: false),
                    ConfeiteiroId = table.Column<int>(nullable: true),
                    IdEntregador = table.Column<int>(nullable: false),
                    EntregadorId = table.Column<int>(nullable: true),
                    IdEndereço = table.Column<int>(nullable: false),
                    EndereçoId = table.Column<int>(nullable: true),
                    IdItem = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: true),
                    Valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Confeiteiro_ConfeiteiroId",
                        column: x => x.ConfeiteiroId,
                        principalTable: "Confeiteiro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Endereço_EndereçoId",
                        column: x => x.EndereçoId,
                        principalTable: "Endereço",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Entregador_EntregadorId",
                        column: x => x.EntregadorId,
                        principalTable: "Entregador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EndereçoId",
                table: "Cliente",
                column: "EndereçoId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoriaId",
                table: "Item",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ConfeiteiroId",
                table: "Item",
                column: "ConfeiteiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ConfeiteiroId",
                table: "Pedido",
                column: "ConfeiteiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EndereçoId",
                table: "Pedido",
                column: "EndereçoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EntregadorId",
                table: "Pedido",
                column: "EntregadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ItemId",
                table: "Pedido",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Entregador");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Endereço");

            migrationBuilder.DropTable(
                name: "Confeiteiro");

            migrationBuilder.AlterColumn<string>(
                name: "Tamanho",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
