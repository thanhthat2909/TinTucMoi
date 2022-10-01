using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeThongTinTuc.Data.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chuyenmuc",
                columns: table => new
                {
                    chuyenmucid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenchuyenmuc = table.Column<string>(nullable: false),
                    thutu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chuyenmuc", x => x.chuyenmucid);
                });

            migrationBuilder.CreateTable(
                name: "bantin",
                columns: table => new
                {
                    bantinid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chuyenmucid = table.Column<int>(nullable: false),
                    tieude = table.Column<string>(nullable: false),
                    tomtat = table.Column<string>(nullable: false),
                    noidung = table.Column<string>(nullable: false),
                    ngaydang = table.Column<DateTime>(nullable: false),
                    nguoidang = table.Column<string>(nullable: true),
                    hinhanh = table.Column<string>(nullable: true),
                    tieudehinh = table.Column<string>(nullable: true),
                    luotxem = table.Column<int>(nullable: false),
                    noibat = table.Column<bool>(nullable: false),
                    kichhoat = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bantin", x => x.bantinid);
                    table.ForeignKey(
                        name: "FK_bantin_chuyenmuc_chuyenmucid",
                        column: x => x.chuyenmucid,
                        principalTable: "chuyenmuc",
                        principalColumn: "chuyenmucid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bantin_chuyenmucid",
                table: "bantin",
                column: "chuyenmucid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bantin");

            migrationBuilder.DropTable(
                name: "chuyenmuc");
        }
    }
}
