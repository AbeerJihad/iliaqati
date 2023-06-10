using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class vssb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4998), "/Images/MealPlan/1.jpg" });

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5004), "/Images/MealPlan/2.jpg" });

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5006), "/Images/MealPlan/3.jpg" });

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(5007), "/Images/MealPlan/4.jpg" });

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
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 6, 56, 59, DateTimeKind.Local).AddTicks(4141));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a5f591c-57cd-4760-af97-ab023b157d83", "2017297f-7f26-41f6-add5-7a0874e29fdc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cadcdb03-ee31-4652-a8b5-9a9ace656e8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ac5f856-70b7-42a7-b8ba-f35d173011a6", "AQAAAAEAACcQAAAAEBRgQtlz74oziDpFTr7e9uO6Qv3K18qgLpFW4EZa7h1iILB/pXAS4CV4gbcHqvk3OA==", "9d2d496f-2e5d-4066-9271-3976bacd4088" });

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "TblConsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "42",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "43",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "44",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "45",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "46",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "47",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "48",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "49",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "50",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "51",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "52",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "53",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "54",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "55",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "56",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "57",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "58",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "59",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "60",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "63",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "64",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "68",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "69",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "70",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "71",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "72",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "73",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "TblExercies_program",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "TblFiles",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "61",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "62",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "65",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "66",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "TblHealthyRecipe",
                keyColumn: "Id",
                keyValue: "67",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5505), "Images/MealPlan/1.jpg" });

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5511), "Images/MealPlan/2.jpg" });

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5512), "Images/MealPlan/3.jpg" });

            migrationBuilder.UpdateData(
                table: "TblMealPlans",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5513), "Images/MealPlan/4.jpg" });

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "TblNotification",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "TblOrder",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "12",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "13",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "14",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "15",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "16",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "17",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "18",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "19",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "20",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "TblOrder_Details",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "TblProducts",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "10",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "6",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "7",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "8",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "TblReplyconsultation",
                keyColumn: "Id",
                keyValue: "9",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "11",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "21",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "22",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "23",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "24",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "25",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "26",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "27",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "28",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "29",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "30",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "31",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "32",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "33",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "34",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "35",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "36",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "37",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "38",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "39",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "40",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "41",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "TblServices",
                keyColumn: "Id",
                keyValue: "5",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "100",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "101",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "102",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "TblSportsProgram",
                keyColumn: "Id",
                keyValue: "103",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "TblTracking",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedDate",
                value: new DateTime(2023, 5, 25, 4, 0, 20, 452, DateTimeKind.Local).AddTicks(5627));
        }
    }
}
