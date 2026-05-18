using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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

            migrationBuilder.InsertData(
                table: "ElementImages",
                columns: new[] { "Id", "Attribution", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "User:Jurii, CC BY 3.0 <https://creativecommons.org/licenses/by/3.0>, via Wikimedia Commons, source: https://images-of-elements.com/hydrogen.php", "Vial of glowing ultrapure hydrogen, H2. Original size in cm: 1 x 5", "https://upload.wikimedia.org/wikipedia/commons/d/d9/Hydrogenglow.jpg" },
                    { 2, "Jurii, CC BY 3.0 <https://creativecommons.org/licenses/by/3.0>, via Wikimedia Commons, source: https://images-of-elements.com/helium.php", "Vial of glowing ultrapure helium. Original size in cm: 1 x 5", "https://upload.wikimedia.org/wikipedia/commons/0/00/Helium-glow.jpg" },
                    { 3, "Hi-Res Images ofChemical Elements, CC BY 3.0 <https://creativecommons.org/licenses/by/3.0>, via Wikimedia Commons, source: https://images-of-elements.com/lithium.php", "0.5 Grams Lithium under Argon. Original size of the largest piece in cm: 0.3 x 4", "https://upload.wikimedia.org/wikipedia/commons/e/e2/0.5_grams_lithium_under_argon.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Elements",
                columns: new[] { "AtomNumber", "Appearance", "AtomicMass", "Block", "BohrModel3D", "BohrModelImage", "Boil", "Category", "CpkHex", "Density", "DiscoveredBy", "ElectronAffinity", "ElectronConfiguration", "ElectronConfigurationSemantic", "ElectronegativityPauling", "ElementImageId", "Group", "IonizationEnergiesRaw", "Melt", "MolarHeat", "Name", "NamedBy", "Period", "Phase", "ShellsRaw", "Source", "SpectralImg", "Summary", "Symbol", "Wxpos", "Wypos", "Xpos", "Ypos" },
                values: new object[,]
                {
                    { 1, "colorless gas", 1.008, "s", "https://storage.googleapis.com/search-ar-edu/periodic-table/element_001_hydrogen/element_001_hydrogen.glb", "https://storage.googleapis.com/search-ar-edu/periodic-table/element_001_hydrogen/element_001_hydrogen_srp_th.png", 20.271000000000001, "diatomic nonmetal", "ffffff", 0.089880000000000002, "Henry Cavendish", 72.769000000000005, "1s1", "1s1", 2.2000000000000002, 1, 1, "1312", 13.99, 28.835999999999999, "Hydrogen", "Antoine Lavoisier", 1, "Gas", "1", "https://en.wikipedia.org/wiki/Hydrogen", "https://en.wikipedia.org/wiki/File:Hydrogen_Spectra.jpg", "Hydrogen is a chemical element with chemical symbol H and atomic number 1. With an atomic weight of 1.00794 u, hydrogen is the lightest element on the periodic table. Its monatomic form (H) is the most abundant chemical substance in the Universe, constituting roughly 75% of all baryonic mass.", "H", 1, 1, 1, 1 },
                    { 2, "colorless gas, exhibiting a red-orange glow when placed in a high-voltage electric field", 4.0026022000000001, "s", "https://storage.googleapis.com/search-ar-edu/periodic-table/element_002_helium/element_002_helium.glb", "https://storage.googleapis.com/search-ar-edu/periodic-table/element_002_helium/element_002_helium_srp_th.png", 4.2220000000000004, "noble gas", "d9ffff", 0.17860000000000001, "Pierre Janssen", -48.0, "1s2", "1s2", null, 2, 18, "2372.3,5250.5", 0.94999999999999996, null, "Helium", null, 1, "Gas", "2", "https://en.wikipedia.org/wiki/Helium", "https://en.wikipedia.org/wiki/File:Helium_spectrum.jpg", "Helium is a chemical element with symbol He and atomic number 2. It is a colorless, odorless, tasteless, non-toxic, inert, monatomic gas that heads the noble gas group in the periodic table. Its boiling and melting points are the lowest among all the elements.", "He", 32, 1, 18, 1 },
                    { 3, "silvery-white", 6.9400000000000004, "s", "https://storage.googleapis.com/search-ar-edu/periodic-table/element_003_lithium/element_003_lithium.glb", "https://storage.googleapis.com/search-ar-edu/periodic-table/element_003_lithium/element_003_lithium_srp_th.png", 1603.0, "alkali metal", "cc80ff", 0.53400000000000003, "Johan August Arfwedson", 59.632599999999996, "1s2 2s1", "[He] 2s1", 0.97999999999999998, 3, 1, "520.2,7298.1,11815", 453.64999999999998, 24.859999999999999, "Lithium", null, 2, "Solid", "2,1", "https://en.wikipedia.org/wiki/Lithium", null, "Lithium (from Greek:λίθος lithos, \"stone\") is a chemical element with the symbol Li and atomic number 3. It is a soft, silver-white metal belonging to the alkali metal group of chemical elements. Under standard conditions it is the lightest metal and the least dense solid element.", "Li", 1, 2, 1, 2 }
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
