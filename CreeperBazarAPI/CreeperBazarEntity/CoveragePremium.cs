using Newtonsoft.Json;

namespace CreeperBazarEntity
{
	public class CoveragePremium
	{
		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }
		public string Lob { get; set; }
		public string Career { get; set; }
		public string CoverageAmount { get; set; }
		public string AnnualPremium { get; set; }
	}
}