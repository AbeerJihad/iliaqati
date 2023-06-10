using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class Databasesd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Trainer",
                table: "TblSportsProgram",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8da27860-d3cd-4c96-bdc5-a410471dc2c4", "9a5fbe4a-37e7-4113-8f4e-a46cee54a4a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cadcdb03-ee31-4652-a8b5-9a9ace656e8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d35b1dc-3fc0-4741-8812-defc4d739721", "AQAAAAEAACcQAAAAEOkSt1wVgIF/TgrBuBsjEDLhuldKeDNcXREx8qDswu8/axn96/VNuZRsWJcZvsLv2g==", "a001514c-48e7-4d88-9515-016d7dcd8b4d" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "63",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "64",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "68",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "69",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "70",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "71",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "72",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "73",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 3, 8, 39, 726, DateTimeKind.Local).AddTicks(2574));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Trainer",
                table: "TblSportsProgram",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0507e860-4ff7-4f2e-9c74-fdf7cae72f96", "80fa4fdd-32bb-49d2-8bed-8ea18ca1d520" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cadcdb03-ee31-4652-a8b5-9a9ace656e8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4075560-5221-4b05-97dd-199f177bf8b0", "AQAAAAEAACcQAAAAEM/x2vI74dryIBY4JWNHfCPTX+DITnFF4OfcB1+fnTal/tdYGc+Nkcnml8ki63cZUg==", "1946603a-d7c4-497a-a5b7-a89e9244a49e" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "63",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "64",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "68",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "69",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "70",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "71",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "72",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "73",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 2, 31, 34, 643, DateTimeKind.Local).AddTicks(8073));
        }
    }
}
