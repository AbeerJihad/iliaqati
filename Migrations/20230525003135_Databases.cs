using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class Databases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TrainingType",
                table: "TblSportsProgram",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Equipment",
                table: "TblSportsProgram",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Difficulty",
                table: "TblSportsProgram",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BodyFocus",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TrainingType",
                table: "TblSportsProgram",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Equipment",
                table: "TblSportsProgram",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Difficulty",
                table: "TblSportsProgram",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BodyFocus",
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
                values: new object[] { "5a1d2db1-c22a-48ea-82bb-bf0be59c9d51", "dfd7cdb8-db71-4383-b371-f8a64d854482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cadcdb03-ee31-4652-a8b5-9a9ace656e8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "469c4a41-9444-4fc3-95b1-60ae9f9cc2b4", "AQAAAAEAACcQAAAAEPBRh4n0xrbh9bRschlDaYKMmHkujr+FgpiEjWMlRf/DfmxUU2fkLZejT/paU1HBdA==", "dcdf5590-ef27-428a-8d93-b9d200bb9498" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "63",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "64",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "68",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "69",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "70",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "71",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "72",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "73",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 1, 49, 55, 798, DateTimeKind.Local).AddTicks(8181));
        }
    }
}
