using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.StepArgumentTransformation;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using  NUnit.Framework;
using Employee.Model;

namespace Employee.Steps
{
    [Binding]
    class EmployeeFeatureSteps
    {
        private List<Model.Employee> employees = new List<Model.Employee>();
        private ScenarioContext sc;
        private EmployeeStepSrgumentTransformation empStepArg = new EmployeeStepSrgumentTransformation();
        public Model.Employee objEmp = new Model.Employee();

        [Given(@"insert employee details")]
        public void GivenInsertEmployeeDetails(Table table)
        {
            
            employees = empStepArg.GetEmployeeDetails(table);
        }

        [When(@"I try to find with ID '(.*)'")]
        public void WhenITryToFindWithID(Model.Employee obj)
        {
            ScenarioContext.Current.Set(obj, "empFound");
        }

        [Then(@"the employee details should be displayed")]
        public void ThenTheEmployeeDetailsShouldBeDisplayed()
        {
            var emp = ScenarioContext.Current.Get<Model.Employee>("empFound");
            Console.WriteLine("Found employee details are:\n");
            Console.WriteLine("Employee id: {0}\nEmployee name: {1}\nEmployee phone number: {2}\nEmployee department: {3}", emp.Id, emp.Name, emp.PhoneNo, emp.Dept);
        }


    }
}
