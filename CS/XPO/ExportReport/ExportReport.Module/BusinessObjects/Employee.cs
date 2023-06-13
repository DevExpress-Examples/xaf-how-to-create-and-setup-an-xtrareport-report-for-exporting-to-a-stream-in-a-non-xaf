using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace ExportReportDemo.Module.BusinessObjects {

    [DefaultClassOptions]
    public class Employee : BaseObject {
        public Employee(Session session) : base(session) { }
        private string firstName;
        private string lastName;
        private string position;
 
        public string FirstName {
            get { return firstName; }
            set { SetPropertyValue("FirstName", ref firstName, value); }
        }
   
        public string LastName {
            get { return lastName; }
            set { SetPropertyValue("LastName", ref lastName, value); }
        }
   
        public string FullName {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        public string Position {
            get { return position; }
            set { SetPropertyValue("Position", ref position, value); }
        }
    }


}
