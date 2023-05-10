using Assignment.Data.ModelData;

namespace Assignment.Data.Models
{
	public class Employee
	{
		public int IDEmployee { get; set; }
		public string Name { get; set; }
		public string NameCompany { get; set; }

		public string IDMember5 { get; set; }
		public string IDCPN { get; set; }
		public Employee() { }

		public Employee ToUi(TableEmployee tableEmployee) //UI ไปเทเบิล
		{

			return new Employee
			{
				IDEmployee = tableEmployee.IDEmployee,
				Name = tableEmployee.Name,
				NameCompany = tableEmployee.NameCompany,
				IDMember5 = tableEmployee.IDMember5,
				IDCPN = tableEmployee.IDCPN,
			};


		}

		public TableEmployee ToTable(Employee NewEmployee)
		{
			return new TableEmployee
			{
				IDEmployee = NewEmployee.IDEmployee,
				Name = NewEmployee.Name,
				NameCompany = NewEmployee.NameCompany,
				IDMember5 = NewEmployee.IDMember5,
				IDCPN = NewEmployee.IDCPN,
			};
		}
	}



}
