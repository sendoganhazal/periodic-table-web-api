using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodicTableApi.Models
{
    public class Element
    {
        [Key]
        [DatabaseGenerated ( DatabaseGeneratedOption.None )]
        [Column ( "AtomNumber" )]
        public int Number { get; set; }

        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public string? Appearance { get; set; }
        public double? AtomicMass { get; set; }
        public double? Boil { get; set; }
        public string? Category { get; set; }
        public double? Density { get; set; }
        public string? DiscoveredBy { get; set; }
        public double? Melt { get; set; }
        public double? MolarHeat { get; set; }
        public string? NamedBy { get; set; }
        public int? Period { get; set; }
        public int? Group { get; set; }
        public string? Phase { get; set; }
        public string? Source { get; set; }
        public string? BohrModelImage { get; set; }
        public string? BohrModel3D { get; set; }
        public string? SpectralImg { get; set; }
        public string? Summary { get; set; }
        public int? Xpos { get; set; }
        public int? Ypos { get; set; }
        public int? Wxpos { get; set; }
        public int? Wypos { get; set; }
        public string? ElectronConfiguration { get; set; }
        public string? ElectronConfigurationSemantic { get; set; } 
        public double? ElectronAffinity { get; set; }
        public double? ElectronegativityPauling { get; set; }
        public string? CpkHex { get; set; }
        public string? Block { get; set; }

        public string ShellsRaw { get; set; } = string.Empty;
        public string IonizationEnergiesRaw { get; set; } = string.Empty;

        public int? ElementImageId { get; set; }
        public ElementImage? Image { get; set; }
    }

    public class ElementImage
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Attribution { get; set; } = string.Empty;
    }
}
