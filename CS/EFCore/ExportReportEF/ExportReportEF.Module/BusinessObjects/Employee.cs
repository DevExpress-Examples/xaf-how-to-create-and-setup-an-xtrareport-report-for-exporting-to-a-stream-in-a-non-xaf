using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Xpo;
using System;

namespace ExportReportDemo.Module.BusinessObjects {

    [DefaultClassOptions]
    public class Employee : BaseObject {
      
 
        public virtual string FirstName { get; set; }
   
        public virtual string LastName { get; set; }
   
        public string FullName {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        public virtual string Position { get; set; }
    }


}
