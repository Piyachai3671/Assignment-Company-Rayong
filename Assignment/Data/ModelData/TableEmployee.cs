using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Data.ModelData
{
	[Table("Employee")]
	public class TableEmployee
	{
		[Key]
		public int IDEmployee { get; set; }
		public string Name { get; set; }
		public string NameCompany { get; set; }
		public string IDMember5 { get; set; }

		public string IDCPN { get; set; }
	}
}
