using Assignment.Data.ModelData;

namespace Assignment.Data.Services
{
	public class CompanyService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public CompanyService(ApplicationContext context)
		{
			_Context = context;
		}

		public async Task<List<TableCompany>> GetEmployeeAsync()
		{
			var u = _Context.TableCompany.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewCompany(TableCompany NewCompany)
		{
			_Context.TableCompany.Add(NewCompany);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void DeleteCompany(TableCompany DeleteCompany)
		{
			var FindID = _Context.TableCompany.First(e => e.IDCompany == DeleteCompany.IDCompany);

			_Context.TableCompany.Remove(FindID);
			_Context.SaveChanges();
		}
		//public void EditEmployee(TableEmployee EditEmployee)
		//{
		//	var FindID = _Context.TableEmployee.First(e => e.IDEmployee == EditEmployee.IDEmployee);
		//	//FindID.Na = EditProduct.RemainderProduct;


		//	_Context.TableEmployee.Update(FindID);
		//	_Context.SaveChanges();//บันทึกลง SQL
		//}
	}
}
