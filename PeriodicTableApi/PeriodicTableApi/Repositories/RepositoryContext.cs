using Microsoft.EntityFrameworkCore;
using PeriodicTableApi.Models;
namespace PeriodicTableApi.Repositories
{
    public class RepositoryContext :DbContext
    {
        public RepositoryContext ( DbContextOptions<RepositoryContext> options ) : base ( options )
        {
        }
        public DbSet<Element> Elements { get; set; }
        public DbSet<ElementImage> ElementImages { get; set; }

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<ElementImage> ( ).HasData (
                new ElementImage
                {
                    Id = 1,
                    Title = "Vial of glowing ultrapure hydrogen, H2. Original size in cm: 1 x 5",
                    Url = "https://upload.wikimedia.org/wikipedia/commons/d/d9/Hydrogenglow.jpg",
                    Attribution = "User:Jurii, CC BY 3.0 <https://creativecommons.org/licenses/by/3.0>, via Wikimedia Commons, source: https://images-of-elements.com/hydrogen.php"
                },
                new ElementImage
                {
                    Id = 2,
                    Title = "Vial of glowing ultrapure helium. Original size in cm: 1 x 5",
                    Url = "https://upload.wikimedia.org/wikipedia/commons/0/00/Helium-glow.jpg",
                    Attribution = "Jurii, CC BY 3.0 <https://creativecommons.org/licenses/by/3.0>, via Wikimedia Commons, source: https://images-of-elements.com/helium.php"
                },
                new ElementImage
                {
                    Id = 3,
                    Title = "0.5 Grams Lithium under Argon. Original size of the largest piece in cm: 0.3 x 4",
                    Url = "https://upload.wikimedia.org/wikipedia/commons/e/e2/0.5_grams_lithium_under_argon.jpg",
                    Attribution = "Hi-Res Images ofChemical Elements, CC BY 3.0 <https://creativecommons.org/licenses/by/3.0>, via Wikimedia Commons, source: https://images-of-elements.com/lithium.php"
                }
            );
            modelBuilder.Entity<Element> ( ).HasData (
                new Element
                {
                    Number = 1,
                    Name = "Hydrogen",
                    Symbol = "H",
                    Appearance = "colorless gas",
                    AtomicMass = 1.008,
                    Boil = 20.271,
                    Category = "diatomic nonmetal",
                    Density = 0.08988,
                    DiscoveredBy = "Henry Cavendish",
                    Melt = 13.99,
                    MolarHeat = 28.836,
                    NamedBy = "Antoine Lavoisier",
                    Period = 1,
                    Group = 1,
                    Phase = "Gas",
                    Source = "https://en.wikipedia.org/wiki/Hydrogen",
                    BohrModelImage = "https://storage.googleapis.com/search-ar-edu/periodic-table/element_001_hydrogen/element_001_hydrogen_srp_th.png",
                    BohrModel3D = "https://storage.googleapis.com/search-ar-edu/periodic-table/element_001_hydrogen/element_001_hydrogen.glb",
                    SpectralImg = "https://en.wikipedia.org/wiki/File:Hydrogen_Spectra.jpg",
                    Summary = "Hydrogen is a chemical element with chemical symbol H and atomic number 1. With an atomic weight of 1.00794 u, hydrogen is the lightest element on the periodic table. Its monatomic form (H) is the most abundant chemical substance in the Universe, constituting roughly 75% of all baryonic mass.",
                    Xpos = 1,
                    Ypos = 1,
                    Wxpos = 1,
                    Wypos = 1,
                    ElectronConfiguration = "1s1",
                    ElectronConfigurationSemantic = "1s1",
                    ElectronAffinity = 72.769,
                    ElectronegativityPauling = 2.2,
                    CpkHex = "ffffff",
                    Block = "s",
                    ShellsRaw = "1",
                    IonizationEnergiesRaw = "1312",
                    ElementImageId = 1 // Birinci görsele bağladık
                },
                new Element
                {
                    Number = 2,
                    Name = "Helium",
                    Symbol = "He",
                    Appearance = "colorless gas, exhibiting a red-orange glow when placed in a high-voltage electric field",
                    AtomicMass = 4.0026022,
                    Boil = 4.222,
                    Category = "noble gas",
                    Density = 0.1786,
                    DiscoveredBy = "Pierre Janssen",
                    Melt = 0.95,
                    MolarHeat = null, // Null atanabilir alanlar için null geçtik
                    NamedBy = null,
                    Period = 1,
                    Group = 18,
                    Phase = "Gas",
                    Source = "https://en.wikipedia.org/wiki/Helium",
                    BohrModelImage = "https://storage.googleapis.com/search-ar-edu/periodic-table/element_002_helium/element_002_helium_srp_th.png",
                    BohrModel3D = "https://storage.googleapis.com/search-ar-edu/periodic-table/element_002_helium/element_002_helium.glb",
                    SpectralImg = "https://en.wikipedia.org/wiki/File:Helium_spectrum.jpg",
                    Summary = "Helium is a chemical element with symbol He and atomic number 2. It is a colorless, odorless, tasteless, non-toxic, inert, monatomic gas that heads the noble gas group in the periodic table. Its boiling and melting points are the lowest among all the elements.",
                    Xpos = 18,
                    Ypos = 1,
                    Wxpos = 32,
                    Wypos = 1,
                    ElectronConfiguration = "1s2",
                    ElectronConfigurationSemantic = "1s2",
                    ElectronAffinity = -48,
                    ElectronegativityPauling = null,
                    CpkHex = "d9ffff",
                    Block = "s",
                    ShellsRaw = "2",
                    IonizationEnergiesRaw = "2372.3,5250.5",
                    ElementImageId = 2 // İkinci görsele bağladık
                },
                new Element
                {
                    Number = 3,
                    Name = "Lithium",
                    Symbol = "Li",
                    Appearance = "silvery-white",
                    AtomicMass = 6.94,
                    Boil = 1603,
                    Category = "alkali metal",
                    Density = 0.534,
                    DiscoveredBy = "Johan August Arfwedson",
                    Melt = 453.65,
                    MolarHeat = 24.86,
                    NamedBy = null,
                    Period = 2,
                    Group = 1,
                    Phase = "Solid",
                    Source = "https://en.wikipedia.org/wiki/Lithium",
                    BohrModelImage = "https://storage.googleapis.com/search-ar-edu/periodic-table/element_003_lithium/element_003_lithium_srp_th.png",
                    BohrModel3D = "https://storage.googleapis.com/search-ar-edu/periodic-table/element_003_lithium/element_003_lithium.glb",
                    SpectralImg = null,
                    Summary = "Lithium (from Greek:λίθος lithos, \"stone\") is a chemical element with the symbol Li and atomic number 3. It is a soft, silver-white metal belonging to the alkali metal group of chemical elements. Under standard conditions it is the lightest metal and the least dense solid element.",
                    Xpos = 1,
                    Ypos = 2,
                    Wxpos = 1,
                    Wypos = 2,
                    ElectronConfiguration = "1s2 2s1",
                    ElectronConfigurationSemantic = "[He] 2s1",
                    ElectronAffinity = 59.6326,
                    ElectronegativityPauling = 0.98,
                    CpkHex = "cc80ff",
                    Block = "s",
                    ShellsRaw = "2,1",
                    IonizationEnergiesRaw = "520.2,7298.1,11815",
                    ElementImageId = 3 // Üçüncü görsele bağladık
                }
            );
        }
    }
}
