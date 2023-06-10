using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e305611e-0bed-42a5-9451-b25ee39dde9a", "3ada5b30-1fa0-4ce6-a50b-7d8132a5df23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cadcdb03-ee31-4652-a8b5-9a9ace656e8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc713c66-5330-4632-ad86-9fe52a508195", "AQAAAAEAACcQAAAAEAB2pY5r3Tczfe5Su8L4YfX4tBhXMFSOlaXHbYyFfdluDNdoDTbiGKnkp2eS4T4QIQ==", "6bf82b89-83c6-411d-bfaa-5d182c159ad1" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "63",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "64",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "68",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "69",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "70",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "71",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "72",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "73",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 9, 6, 10, 712, DateTimeKind.Local).AddTicks(2823));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 36, 58, 805, DateTimeKind.Local).AddTicks(1517));

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
    }
}
