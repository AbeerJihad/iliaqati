using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class vssbsdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75909a19-e277-487b-b9b5-ab36990a2d33", "6578da04-9837-46b8-9004-9b577e633227" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cadcdb03-ee31-4652-a8b5-9a9ace656e8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6c06cba-5a08-4586-8351-0319172f7558", "AQAAAAEAACcQAAAAEAEqj0XS/4rq6ALt0KOAEO/sBkELWqQa0jcdJbI1hSy8hyxTw7SsMiGPNeNNmr836g==", "ad8e4034-30d3-4a46-8306-721b52fe1b3d" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "63",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "64",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "68",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "69",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "70",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "71",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "72",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "73",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1487), "/Images/Program/10.jpg" });

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1513), "/Images/Program/11.jpg" });

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1516), "/Images/Program/12.jpg" });

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1517), "/Images/Program/13.jpg" });

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(2489));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34c5f234-0d6a-4afe-b357-aa16292405aa", "ddf0f2fc-ebd7-4111-bf38-ce2a2f82046f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cadcdb03-ee31-4652-a8b5-9a9ace656e8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f9ede0-5172-47c6-8512-1a73459c59b9", "AQAAAAEAACcQAAAAEAfPxtbZbcFKeQVIXJIIYuEX6nFYeUVVlFrvQoraAdcmS9RGLjsGXJX6WrtlP5x4JQ==", "7b9c5909-b105-4f67-bcc9-6584cca4ef1b" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "63",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "64",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "68",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "69",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "70",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "71",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "72",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "73",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4105), "Images/Program/10.jpg" });

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4137), "Images/Program/11.jpg" });

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4139), "Images/Program/12.jpg" });

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4141), "Images/Program/13.jpg" });

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5100));
        }
    }
}
