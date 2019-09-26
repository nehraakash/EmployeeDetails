using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Employee.Model;

namespace Employee.StepArgumentTransformation
{
    [Binding]
    public class EmployeeStepSrgumentTransformation
    {
        private Model.Employee objEmp;
        public static List<Model.Employee> employees = new List<Model.Employee>();
        
        [StepArgumentTransformation(@"(\d+)")]
        public Model.Employee Demo(int id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == id.ToString())
                {
                    objEmp = emp;
                    break;
                }
            }
            return objEmp;
        }

        public List<Model.Employee> GetEmployeeDetails(Table table)
        {
            employees = table.CreateSet<Model.Employee>().ToList();
            return employees;
        }
    }
}
