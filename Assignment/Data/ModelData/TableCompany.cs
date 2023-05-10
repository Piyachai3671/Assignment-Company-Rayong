using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Data.ModelData
{
	[Table("Company")]
	public class TableCompany
	{
		[Key]
		public int IDCompany { get; set; }
		public string Name { get; set; }
		public string IDCPN { get; set; }
	}
}
