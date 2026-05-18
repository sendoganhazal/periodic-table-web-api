using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicTableApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialFullPeriodicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElementImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    Attribution = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    AtomNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Symbol = table.Column<string>(type: "TEXT", nullable: true),
                    Appearance = table.Column<string>(type: "TEXT", nullable: true),
                    AtomicMass = table.Column<double>(type: "REAL", nullable: true),
                    Boil = table.Column<double>(type: "REAL", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Density = table.Column<double>(type: "REAL", nullable: true),
                    DiscoveredBy = table.Column<string>(type: "TEXT", nullable: true),
                    Melt = table.Column<double>(type: "REAL", nullable: true),
                    MolarHeat = table.Column<double>(type: "REAL", nullable: true),
                    NamedBy = table.Column<string>(type: "TEXT", nullable: true),
                    Period = table.Column<int>(type: "INTEGER", nullable: true),
                    Group = table.Column<int>(type: "INTEGER", nullable: true),
                    Phase = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    BohrModelImage = table.Column<string>(type: "TEXT", nullable: true),
                    BohrModel3D = table.Column<string>(type: "TEXT", nullable: true),
                    SpectralImg = table.Column<string>(type: "TEXT", nullable: true),
                    Summary = table.Column<string>(type: "TEXT", nullable: true),
                    Xpos = table.Column<int>(type: "INTEGER", nullable: true),
                    Ypos = table.Column<int>(type: "INTEGER", nullable: true),
                    Wxpos = table.Column<int>(type: "INTEGER", nullable: true),
                    Wypos = table.Column<int>(type: "INTEGER", nullable: true),
                    ElectronConfiguration = table.Column<string>(type: "TEXT", nullable: true),
                    ElectronConfigurationSemantic = table.Column<string>(type: "TEXT", nullable: true),
                    ElectronAffinity = table.Column<double>(type: "REAL", nullable: true),
                    ElectronegativityPauling = table.Column<double>(type: "REAL", nullable: true),
                    CpkHex = table.Column<string>(type: "TEXT", nullable: true),
                    Block = table.Column<string>(type: "TEXT", nullable: true),
                    ShellsRaw = table.Column<string>(type: "TEXT", nullable: false),
                    IonizationEnergiesRaw = table.Column<string>(type: "TEXT", nullable: false),
                    ElementImageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.AtomNumber);
                    table.ForeignKey(
                        name: "FK_Elements_ElementImages_ElementImageId",
                        column: x => x.ElementImageId,
                        principalTable: "ElementImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elements_ElementImageId",
                table: "Elements",
                column: "ElementImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "ElementImages");
        }
    }
}
