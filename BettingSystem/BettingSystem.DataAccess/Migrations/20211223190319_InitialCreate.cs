using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingSystem.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SportEntity",
                columns: table => new
                {
                    SportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportEntity", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SportEntitySportId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_SportEntity_SportEntitySportId",
                        column: x => x.SportEntitySportId,
                        principalTable: "SportEntity",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "XmlSports",
                columns: table => new
                {
                    XmlSportsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SportId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XmlSports", x => x.XmlSportsId);
                    table.ForeignKey(
                        name: "FK_XmlSports_SportEntity_SportId",
                        column: x => x.SportId,
                        principalTable: "SportEntity",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatchType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventEntityEventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                    table.ForeignKey(
                        name: "FK_Matches_Events_EventEntityEventId",
                        column: x => x.EventEntityEventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    BetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false),
                    MatchEntityMatchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.BetId);
                    table.ForeignKey(
                        name: "FK_Bets_Matches_MatchEntityMatchId",
                        column: x => x.MatchEntityMatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Odds",
                columns: table => new
                {
                    OddId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    SpecialBetValue = table.Column<double>(type: "float", nullable: true),
                    BetEntityBetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odds", x => x.OddId);
                    table.ForeignKey(
                        name: "FK_Odds_Bets_BetEntityBetId",
                        column: x => x.BetEntityBetId,
                        principalTable: "Bets",
                        principalColumn: "BetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bets_MatchEntityMatchId",
                table: "Bets",
                column: "MatchEntityMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SportEntitySportId",
                table: "Events",
                column: "SportEntitySportId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_EventEntityEventId",
                table: "Matches",
                column: "EventEntityEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Odds_BetEntityBetId",
                table: "Odds",
                column: "BetEntityBetId");

            migrationBuilder.CreateIndex(
                name: "IX_XmlSports_SportId",
                table: "XmlSports",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Odds");

            migrationBuilder.DropTable(
                name: "XmlSports");

            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "SportEntity");
        }
    }
}
