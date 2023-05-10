using Assignment.Data.ModelData;

namespace Assignment.Data.Models
{
	public class Company
	{
		public int IDCompany { get; set; }
		public string Name { get; set; }
		public string IDCPN { get; set; }
		public Company() { }

		public Company ToUi(TableCompany tableCompany) //UI ไปเทเบิล
		{

			return new Company
			{
				IDCompany = tableCompany.IDCompany,
				Name = tableCompany.Name,
				
			};

		}

		public TableCompany ToTable(Company NewCompany)
		{
			return new TableCompany
			{
				IDCompany = NewCompany.IDCompany,
				Name = NewCompany.Name,

				
			};
		}
	}




}
