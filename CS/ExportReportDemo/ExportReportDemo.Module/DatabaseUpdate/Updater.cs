using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using ExportReportDemo.Module.BusinessObjects;

namespace ExportReportDemo.Module.DatabaseUpdate {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreateEmployees();
        }
        private void CreateEmployees()
        {
            AddEmployee("Andrew", "Fuller", "Sales Manager");
            AddEmployee("Mary", "Telitson", "Developer");
            AddEmployee("Michael", "Suyama", "Developer");
            AddEmployee("Nancy", "Davolio", "Developer");
            AddEmployee("Robert", "King", "Senior Developer");
            AddEmployee("Steven", "Buchanan", "Developer");
        }
        private void AddEmployee(string name, string lastName, string position)
        {
            Employee employee = ObjectSpace.FindObject<Employee>(CriteriaOperator.Parse(string.Format("FirstName == '{0}' && LastName == '{1}'", name, lastName)));
            if (employee == null)
            {
                employee = ObjectSpace.CreateObject<Employee>();
                employee.FirstName = name;
                employee.LastName = lastName;
                employee.Position = position;
            }
        }

    }
}
