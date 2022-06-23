using EmployeeOrganizationDFFirst.Models;

namespace EFDBFirst.Data
{
    public class CRUDmanager
    {
        EmplyoeesOrganizationDFContext dBFirstContext = new EmplyoeesOrganizationDFContext();
        public Employee GetEmplpoyeeById(int employeeId)
        {
            var employee = dBFirstContext.Employees.Where(x => x.Name == "Yogesh")
                          .OrderBy(s => s.Name).ThenByDescending(s => s.Address).Last();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }
            return employee;
        }
        public List<Employee> GetAllEmployees()
        {
            var employee = dBFirstContext.Employees.ToList();
            return employee;
        }
        public void InsertEmplyoee(Employee employee)
        {
            dBFirstContext.Employees.Add(employee);
            dBFirstContext.SaveChanges();
        }
        public void UpdateEmployee(int ID,Employee updatedEmployee)
        {
            var employee = dBFirstContext.Employees.Where(x => x.Id == ID).FirstOrDefault();
            if(employee!=null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Address = updatedEmployee.Address;
                dBFirstContext.Employees.Update(employee);
                dBFirstContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("employee with id " + ID + " not exits");
            }
        }
        public void DeleteEmployee(int ID)
        {
            var employee = dBFirstContext.Employees.Where(x => x.Id == ID).FirstOrDefault();
            if(employee!=null)
            {
                dBFirstContext.Employees.Remove(employee);
                dBFirstContext.SaveChanges();
            }
            else
            { 
                Console.WriteLine("employee with id " + ID + " not exits"); 
            }
        }
    }
}