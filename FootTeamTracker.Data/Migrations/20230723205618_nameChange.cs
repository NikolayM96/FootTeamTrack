using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootTeamTracker.Data.Migrations
{
    public partial class nameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("1394170d-5678-4e86-9604-b010d584c4e5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("1792adaa-353f-427e-aa87-ac9e40380930"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("1b6e7a98-d40f-41f5-8eb5-d69c818a98b5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("3241f2bb-ca45-4544-a500-0d09e6913d7e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("422060de-7ec0-461a-899a-e1cd2116e6d5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("56b2a520-1063-4b75-8368-cd04fc6c32e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("83290e5a-bc34-4afe-b8a8-3676ae5f0c35"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("8719a440-0d83-4bcf-bb94-6b1b635f421b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("8e789b53-78e7-4c6b-8267-8d9531d09bfd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("9e3dc5a5-f071-4612-b12d-aff54de53d2d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("9fbc0007-740f-4200-8be4-2d7b5084f290"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("b14a791c-206b-48d0-9e71-c3d12aaca728"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("c0ecc93e-354f-4162-a2b9-f440b0108b4b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("c63a8a13-ac8b-4a1b-97da-7c71cbe63401"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("d18827a9-4b5a-41c3-af03-ea73547570f2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("dede3d93-7e4f-4421-96b9-17c221e186e7"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("f4f7d341-f05b-4624-ba98-2e46585337da"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("f9285faa-98cb-45da-b7aa-aed62f3d7c3f"));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 12, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 14, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 15, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 9, 6, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 5, 18, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 8, 26, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 10, 12, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 10, 21, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 12, 4, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 1, 30, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 2, 29, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 10, 28, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 2, 8, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 2, 7, 23, 56, 18, 98, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "IsReserved", "StadiumId", "TicketHolderId", "UserId" },
                values: new object[,]
                {
                    { new Guid("281f15c8-b8c2-4cb1-bd87-49beb77615e9"), false, 5, null, null },
                    { new Guid("442bd98b-9fa0-4714-ace2-031d0c2ff130"), false, 1, null, null },
                    { new Guid("476240c9-9c44-40e9-be59-ad3e2df75d77"), false, 3, null, null },
                    { new Guid("64b18b2b-765f-472e-9ce7-57090eb97f69"), false, 1, null, null },
                    { new Guid("6a933b09-6841-4115-a50d-2af0921163e9"), false, 2, null, null },
                    { new Guid("6f64097d-c713-49ac-b899-3259723b1a54"), false, 4, null, null },
                    { new Guid("703898d2-54f6-4253-98e9-0d558c3031e8"), false, 4, null, null },
                    { new Guid("9751c6dd-958e-4de2-8651-998ff9d613a3"), false, 3, null, null },
                    { new Guid("9a83667f-8413-4170-b5ed-6ac25642e91a"), false, 2, null, null },
                    { new Guid("9b68fd76-7da6-4054-85d1-7b0ade6b793d"), false, 5, null, null },
                    { new Guid("9cd75bce-23fd-4b4a-9f0d-28c221752bed"), false, 4, null, null },
                    { new Guid("a962d8b2-2efd-4bee-920a-bcc4cccabc00"), false, 2, null, null },
                    { new Guid("b401899c-d549-4307-9f84-20bf8c509769"), false, 3, null, null },
                    { new Guid("c9d18dde-92ae-43fd-82eb-5f7998cc0cbd"), false, 2, null, null },
                    { new Guid("d1d21b9c-a4df-4b2b-b6b0-b0551300d924"), false, 3, null, null },
                    { new Guid("d784bad6-2144-4944-9ed5-73b123747767"), false, 1, null, null },
                    { new Guid("df1cbc9e-9e92-4aa3-a4ee-da7d8eb76960"), false, 5, null, null },
                    { new Guid("e0daf9c7-8896-4ca8-b390-940caa84f136"), false, 1, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("281f15c8-b8c2-4cb1-bd87-49beb77615e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("442bd98b-9fa0-4714-ace2-031d0c2ff130"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("476240c9-9c44-40e9-be59-ad3e2df75d77"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("64b18b2b-765f-472e-9ce7-57090eb97f69"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("6a933b09-6841-4115-a50d-2af0921163e9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("6f64097d-c713-49ac-b899-3259723b1a54"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("703898d2-54f6-4253-98e9-0d558c3031e8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("9751c6dd-958e-4de2-8651-998ff9d613a3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("9a83667f-8413-4170-b5ed-6ac25642e91a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("9b68fd76-7da6-4054-85d1-7b0ade6b793d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("9cd75bce-23fd-4b4a-9f0d-28c221752bed"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a962d8b2-2efd-4bee-920a-bcc4cccabc00"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("b401899c-d549-4307-9f84-20bf8c509769"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("c9d18dde-92ae-43fd-82eb-5f7998cc0cbd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("d1d21b9c-a4df-4b2b-b6b0-b0551300d924"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("d784bad6-2144-4944-9ed5-73b123747767"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("df1cbc9e-9e92-4aa3-a4ee-da7d8eb76960"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("e0daf9c7-8896-4ca8-b390-940caa84f136"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 11, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 13, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 14, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 9, 5, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 5, 17, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 8, 25, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 10, 11, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 10, 20, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 12, 3, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 1, 29, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 2, 28, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 10, 27, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 2, 7, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 2, 29, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 2, 6, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "IsReserved", "StadiumId", "TicketHolderId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1394170d-5678-4e86-9604-b010d584c4e5"), false, 5, null, null },
                    { new Guid("1792adaa-353f-427e-aa87-ac9e40380930"), false, 1, null, null },
                    { new Guid("1b6e7a98-d40f-41f5-8eb5-d69c818a98b5"), false, 4, null, null },
                    { new Guid("3241f2bb-ca45-4544-a500-0d09e6913d7e"), false, 3, null, null },
                    { new Guid("422060de-7ec0-461a-899a-e1cd2116e6d5"), false, 5, null, null },
                    { new Guid("56b2a520-1063-4b75-8368-cd04fc6c32e9"), false, 1, null, null },
                    { new Guid("83290e5a-bc34-4afe-b8a8-3676ae5f0c35"), false, 2, null, null },
                    { new Guid("8719a440-0d83-4bcf-bb94-6b1b635f421b"), false, 2, null, null },
                    { new Guid("8e789b53-78e7-4c6b-8267-8d9531d09bfd"), false, 3, null, null },
                    { new Guid("9e3dc5a5-f071-4612-b12d-aff54de53d2d"), false, 1, null, null },
                    { new Guid("9fbc0007-740f-4200-8be4-2d7b5084f290"), false, 3, null, null },
                    { new Guid("b14a791c-206b-48d0-9e71-c3d12aaca728"), false, 4, null, null },
                    { new Guid("c0ecc93e-354f-4162-a2b9-f440b0108b4b"), false, 1, null, null },
                    { new Guid("c63a8a13-ac8b-4a1b-97da-7c71cbe63401"), false, 4, null, null },
                    { new Guid("d18827a9-4b5a-41c3-af03-ea73547570f2"), false, 3, null, null },
                    { new Guid("dede3d93-7e4f-4421-96b9-17c221e186e7"), false, 5, null, null },
                    { new Guid("f4f7d341-f05b-4624-ba98-2e46585337da"), false, 2, null, null },
                    { new Guid("f9285faa-98cb-45da-b7aa-aed62f3d7c3f"), false, 2, null, null }
                });
        }
    }
}
