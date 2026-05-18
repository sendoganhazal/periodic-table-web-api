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

        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public string Appearance { get; set; } = string.Empty;
        public double? AtomicMass { get; set; }
        public double? Boil { get; set; }
        public string Category { get; set; } = string.Empty;
        public double? Density { get; set; }
        public string DiscoveredBy { get; set; } = string.Empty;
        public double? Melt { get; set; }
        public double? MolarHeat { get; set; }
        public string NamedBy { get; set; } = string.Empty;
        public int Period { get; set; }
        public int Group { get; set; }
        public string Phase { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string BohrModelImage { get; set; } = string.Empty;
        public string BohrModel3D { get; set; } = string.Empty;
        public string SpectralImg { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int Wxpos { get; set; }
        public int Wypos { get; set; }
        public string ElectronConfiguration { get; set; } = string.Empty;
        public string ElectronConfigurationSemantic { get; set; } = string.Empty;
        public double? ElectronAffinity { get; set; }
        public double? ElectronegativityPauling { get; set; }
        public string CpkHex { get; set; } = string.Empty;
        public string Block { get; set; } = string.Empty;

        public string ShellsRaw { get; set; } = string.Empty;
        public string IonizationEnergiesRaw { get; set; } = string.Empty;

        public int? ElementImageId { get; set; }
        public ElementImage? Image { get; set; }
    }
}
