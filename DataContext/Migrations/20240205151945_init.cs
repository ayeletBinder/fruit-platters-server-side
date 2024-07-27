using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataContext.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repository.Interface.IContext.Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repository.Interface.IContext.Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repository.Interface.IContext.Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Payment = table.Column<int>(type: "int", nullable: false),
                    AddressToSend = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceSum = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExecutionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repository.Interface.IContext.Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repository.Interface.IContext.Orders_Repository.Interface.IContext.Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Repository.Interface.IContext.Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repository.Interface.IContext.Trays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    NumHeart = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repository.Interface.IContext.Trays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repository.Interface.IContext.Trays_Repository.Interface.IContext.Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Repository.Interface.IContext.Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Repository.Interface.IContext.Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    TrayId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repository.Interface.IContext.Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repository.Interface.IContext.Comments_Repository.Interface.IContext.Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Repository.Interface.IContext.Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repository.Interface.IContext.Comments_Repository.Interface.IContext.Trays_TrayId",
                        column: x => x.TrayId,
                        principalTable: "Repository.Interface.IContext.Trays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repository.Interface.IContext.Fruits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdditionalCharge = table.Column<bool>(type: "bit", nullable: false),
                    SomeAdditional = table.Column<int>(type: "int", nullable: false),
                    IsExists = table.Column<bool>(type: "bit", nullable: false),
                    TrayId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repository.Interface.IContext.Fruits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repository.Interface.IContext.Fruits_Repository.Interface.IContext.Trays_TrayId",
                        column: x => x.TrayId,
                        principalTable: "Repository.Interface.IContext.Trays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repository.Interface.IContext.Comments_ClientId",
                table: "Repository.Interface.IContext.Comments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Repository.Interface.IContext.Comments_TrayId",
                table: "Repository.Interface.IContext.Comments",
                column: "TrayId");

            migrationBuilder.CreateIndex(
                name: "IX_Repository.Interface.IContext.Fruits_TrayId",
                table: "Repository.Interface.IContext.Fruits",
                column: "TrayId");

            migrationBuilder.CreateIndex(
                name: "IX_Repository.Interface.IContext.Orders_ClientId",
                table: "Repository.Interface.IContext.Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Repository.Interface.IContext.Trays_OrderId",
                table: "Repository.Interface.IContext.Trays",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repository.Interface.IContext.Comments");

            migrationBuilder.DropTable(
                name: "Repository.Interface.IContext.Fruits");

            migrationBuilder.DropTable(
                name: "Repository.Interface.IContext.Trays");

            migrationBuilder.DropTable(
                name: "Repository.Interface.IContext.Orders");

            migrationBuilder.DropTable(
                name: "Repository.Interface.IContext.Clients");
        }
    }
}
