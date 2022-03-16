using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tourtimes",
                columns: table => new
                {
                    TourTimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tourtimes", x => x.TourTimeId);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    TourTimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_responses_tourtimes_TourTimeId",
                        column: x => x.TourTimeId,
                        principalTable: "tourtimes",
                        principalColumn: "TourTimeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 1, "Monday 8:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 66, "Saturday 8:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 65, "Friday 8:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 64, "Friday 7:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 63, "Friday 6:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 62, "Friday 5:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 61, "Friday 4:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 60, "Friday 3:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 59, "Friday 2:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 58, "Friday 1:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 57, "Friday 12:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 56, "Friday 11:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 55, "Friday 10:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 54, "Friday 9:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 53, "Friday 8:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 52, "Thursday 8:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 51, "Thursday 7:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 50, "Thursday 6:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 49, "Thursday 5:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 48, "Thursday 4:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 67, "Saturday 9:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 47, "Thursday 3:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 68, "Saturday 10:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 70, "Saturday 12:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 89, "Sunday 6:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 88, "Sunday 5:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 87, "Sunday 4:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 86, "Sunday 3:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 85, "Sunday 2:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 84, "Sunday 1:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 83, "Sunday 12:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 82, "Sunday 11:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 81, "Sunday 10:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 80, "Sunday 9:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 79, "Sunday 8:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 78, "Saturday 8:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 77, "Saturday 7:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 76, "Saturday 6:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 75, "Saturday 5:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 74, "Saturday 4:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 73, "Saturday 3:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 72, "Saturday 2:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 71, "Saturday 1:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 69, "Saturday 11:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 90, "Sunday 7:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 46, "Thursday 2:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 44, "Thursday 12:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 20, "Tuesday 2:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 19, "Tuesday 1:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 18, "Tuesday 12:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 17, "Tuesday 11:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 16, "Tuesday 10:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 15, "Tuesday 9:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 14, "Tuesday 8:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 13, "Monday 8:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 12, "Monday 7:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 11, "Monday 6:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 10, "Monday 5:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 9, "Monday 4:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 8, "Monday 3:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 7, "Monday 2:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 6, "Monday 1:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 5, "Monday 12:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 4, "Monday 11:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 3, "Monday 10:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 2, "Monday 9:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 21, "Tuesday 3:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 45, "Thursday 1:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 22, "Tuesday 4:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 24, "Tuesday 6:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 43, "Thursday 11:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 42, "Thursday 10:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 41, "Thursday 9:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 40, "Thursday 8:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 39, "Wednesday 8:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 38, "Wednesday 7:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 37, "Wednesday 6:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 36, "Wednesday 5:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 35, "Wednesday 4:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 34, "Wednesday 3:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 33, "Wednesday 2:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 32, "Wednesday 1:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 31, "Wednesday 12:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 30, "Wednesday 11:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 29, "Wednesday 10:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 28, "Wednesday 9:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 27, "Wednesday 8:00 AM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 26, "Tuesday 8:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 25, "Tuesday 7:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 23, "Tuesday 5:00 PM" });

            migrationBuilder.InsertData(
                table: "tourtimes",
                columns: new[] { "TourTimeId", "Time" },
                values: new object[] { 91, "Sunday 8:00 PM" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "AppointmentId", "Email", "GroupName", "GroupSize", "Phone", "TourTimeId" },
                values: new object[] { 1, "blah@blah.com", "test", 4, "555-555-5555", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_TourTimeId",
                table: "responses",
                column: "TourTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "tourtimes");
        }
    }
}
