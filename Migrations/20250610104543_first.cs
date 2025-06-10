using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kolokwium1.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "MatchId",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2025, 6, 10, 12, 45, 42, 876, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2025, 6, 10, 12, 45, 42, 872, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2025, 6, 10, 12, 45, 42, 872, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Tournament",
                keyColumn: "TournamentId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 10, 12, 45, 42, 873, DateTimeKind.Local).AddTicks(3936), new DateTime(2025, 6, 10, 12, 45, 42, 873, DateTimeKind.Local).AddTicks(3923) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "MatchId",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2025, 6, 10, 12, 45, 30, 934, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2025, 6, 10, 12, 45, 30, 930, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2025, 6, 10, 12, 45, 30, 930, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Tournament",
                keyColumn: "TournamentId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 10, 12, 45, 30, 930, DateTimeKind.Local).AddTicks(9316), new DateTime(2025, 6, 10, 12, 45, 30, 930, DateTimeKind.Local).AddTicks(9281) });
        }
    }
}
