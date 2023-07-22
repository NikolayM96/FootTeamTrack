using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootTeamTracker.Data.Migrations
{
    public partial class SeedFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Location", "Name", "SeatingCapacity" },
                values: new object[,]
                {
                    { 1, "London, England", "Wembley Stadium", 90000 },
                    { 2, "Barcelona, Spain", "Camp Nou", 99354 },
                    { 3, "Munich, Germany", "Allianz Arena", 75000 },
                    { 4, "Manchester, England", "Old Trafford", 74609 },
                    { 5, "Milan, Italy", "San Siro", 80018 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamName", "Date", "HomeTeamName", "StadiumId" },
                values: new object[,]
                {
                    { 1, "Barcelona", new DateTime(2024, 3, 11, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5103), "Arsenal", 2 },
                    { 2, "PSG", new DateTime(2024, 3, 13, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5110), "Arsenal", 2 },
                    { 3, "Barcelona", new DateTime(2024, 3, 14, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5115), "PSG", 2 },
                    { 4, "Real Madrid", new DateTime(2024, 9, 5, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5120), "Arsenal", 3 },
                    { 5, "PSG", new DateTime(2024, 5, 17, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5125), "Arsenal", 3 },
                    { 6, "Real Madrid", new DateTime(2024, 8, 25, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5132), "Manchester United", 3 },
                    { 7, "Barcelona", new DateTime(2023, 10, 11, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5137), "Arsenal", 4 },
                    { 8, "PSG", new DateTime(2023, 10, 20, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5142), "Manchester United", 4 },
                    { 9, "Barcelona", new DateTime(2024, 12, 3, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5146), "Arsenal", 4 },
                    { 10, "Barcelona", new DateTime(2024, 1, 29, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5151), "Arsenal", 5 },
                    { 11, "PSG", new DateTime(2024, 2, 28, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5156), "Arsenal", 5 },
                    { 12, "Barcelona", new DateTime(2023, 10, 27, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5161), "PSG", 5 },
                    { 13, "Barcelona", new DateTime(2024, 2, 7, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5041), "Arsenal", 1 },
                    { 14, "Manchester United", new DateTime(2024, 2, 29, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5092), "Arsenal", 1 },
                    { 15, "Barcelona", new DateTime(2024, 2, 6, 21, 28, 43, 773, DateTimeKind.Local).AddTicks(5098), "Real Madrid", 1 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Logo", "Name", "NewsId", "StadiumId" },
                values: new object[,]
                {
                    { 1, "arsenal_logo_PNG1.png", "Arsenal", null, 1 },
                    { 2, "Barcelona-Logo-PNG1.png", "Barcelona", null, 2 },
                    { 3, "PSG-Logo-PNG1.png", "PSG", null, 3 },
                    { 4, "Real_Madrid_logo_PNG5.png", "Real Madrid", null, 4 },
                    { 5, "manchester_united_logo_PNG3.png", "Manchester United", null, 5 }
                });

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

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "Date", "ImageUrl", "TeamId", "Title" },
                values: new object[] { 1, "The team secured a victory in the championship match.", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Champions.jpg", 1, "Team Wins Championship" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "DateOfBirth", "GamesPlayed", "Goals", "InjuryId", "Name", "Position", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 5, 0, "Bukayo Saka", 0, 1 },
                    { 2, new DateTime(1998, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, 0, "Martin Odegaard", 2, 1 },
                    { 3, new DateTime(1993, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, 0, "Ben White", 1, 1 },
                    { 4, new DateTime(1997, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 10, 0, "Lionel Messi", 0, 2 },
                    { 5, new DateTime(1990, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, 0, "David De Gea", 3, 2 },
                    { 6, new DateTime(1985, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 900, 800, 0, "Cristiano Ronaldo", 0, 2 },
                    { 7, new DateTime(1992, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 300, 0, "Neymar Jr", 0, 3 },
                    { 8, new DateTime(1991, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 300, 20, 0, "Virgil van Dijk", 1, 3 },
                    { 9, new DateTime(1991, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 400, 100, 0, "Kevin De Bruyne", 2, 3 },
                    { 10, new DateTime(1998, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, 150, 0, "Kylian Mbappé", 0, 4 },
                    { 11, new DateTime(1988, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 600, 400, 0, "Robert Lewandowski", 0, 4 },
                    { 12, new DateTime(1986, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 100, 0, "Sergio Ramos", 1, 4 },
                    { 13, new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 400, 50, 0, "Kevin Mbappe", 2, 5 },
                    { 14, new DateTime(1992, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 300, 0, 0, "Alisson Becker", 3, 5 },
                    { 15, new DateTime(1992, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 400, 200, 0, "Mohamed Salah", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "TrainingSessions",
                columns: new[] { "Id", "Date", "Location", "Objectives", "TeamId", "Time" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training Ground 1", "Improve passing and teamwork", 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training Ground 2", "Focus on defensive drills", 2, new TimeSpan(0, 4, 0, 0, 0) },
                    { 3, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training Ground 3", "Improve fitness and conditioning", 3, new TimeSpan(0, 6, 30, 0, 0) },
                    { 4, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training Ground 4", "Work on set-piece routines", 4, new TimeSpan(0, 6, 20, 15, 0) },
                    { 5, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training Ground 5", "Improve shooting accuracy", 5, new TimeSpan(0, 1, 55, 22, 0) }
                });

            migrationBuilder.InsertData(
                table: "Trophies",
                columns: new[] { "Id", "Description", "Name", "TeamId", "Year" },
                values: new object[,]
                {
                    { 1, "The FIFA World Cup is the most prestigious international football tournament held every four years.", "FIFA World Cup", 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "The UEFA Champions League is an annual club football competition organized by the Union of European Football Associations (UEFA).", "UEFA Champions League", 2, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "The FIFA Club World Cup is an international men's association football competition organized by the Fédération Internationale de Football Association (FIFA).", "FIFA Club World Cup", 3, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "The UEFA European Championship is the primary association football competition contested by the senior men's national teams of the members of UEFA.", "UEFA European Championship", 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "The Premier League is the top professional football league in England.", "Premier League", 5, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Injuries",
                columns: new[] { "Id", "Date", "ExpectedRecoveryTime", "PlayerId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(12599999400), 1, "Sprained Ankle" },
                    { 2, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(9599999400), 2, "Muscle Strain" },
                    { 3, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(8399999400), 3, "Hamstring Injury" },
                    { 4, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(7199999400), 4, "Knee Ligament Tear" },
                    { 5, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(2399999400), 5, "Concussion" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Injuries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Injuries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Injuries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Injuries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Injuries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

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

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trophies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trophies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trophies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trophies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trophies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
