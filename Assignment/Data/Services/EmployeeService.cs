using Assignment.Data.ModelData;

namespace Assignment.Data.Services
{
	public class EmployeeService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public EmployeeService(ApplicationContext context)
		{
			_Context = context;
		}
		public async Task<List<TableEmployee>> GetEmployeeAsync()
		{
			var u = _Context.TableEmployee.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewEmployee(TableEmployee NewEmployee)
		{
			_Context.TableEmployee.Add(NewEmployee);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void DeleteEmployee(TableEmployee DeleteEmployee)
		{
			var FindID = _Context.TableEmployee.First(e => e.IDEmployee == DeleteEmployee.IDEmployee);

			_Context.TableEmployee.Remove(FindID);
			_Context.SaveChanges();
		}
		public void EditEmployee(TableEmployee EditEmployee)
		{
			var FindID = _Context.TableEmployee.First(e => e.IDEmployee == EditEmployee.IDEmployee);
			FindID.Name = EditEmployee.Name;
			FindID.NameCompany = EditEmployee.NameCompany;


			_Context.TableEmployee.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
	}
}
