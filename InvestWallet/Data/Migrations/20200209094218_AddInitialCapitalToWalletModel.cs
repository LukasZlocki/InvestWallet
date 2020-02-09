using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestWallet.Data.Migrations
{
    public partial class AddInitialCapitalToWalletModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "InitialCapital",
                table: "Wallet",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InitialCapital",
                table: "Wallet");
        }
    }
}
