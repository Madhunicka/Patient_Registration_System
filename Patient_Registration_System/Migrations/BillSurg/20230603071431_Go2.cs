using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patient_Registration_System.Migrations.BillSurg
{
    /// <inheritdoc />
    public partial class Go2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Billsurgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientName = table.Column<string>(type: "TEXT", nullable: false),
                    SurgCharge = table.Column<double>(type: "REAL", nullable: false),
                    MedicationCost = table.Column<double>(type: "REAL", nullable: false),
                    LabTests = table.Column<double>(type: "REAL", nullable: false),
                    ServiceCharges = table.Column<double>(type: "REAL", nullable: false),
                    AdditionalCharge = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billsurgs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billsurgs");
        }
    }
}
