using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportReportDemoEF.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Employee
    {
        [Browsable(false)]
        public int ID { get; set; }
        [VisibleInListView(false)]
        public string FirstName { get; set; }
        [VisibleInListView(false)]
        public string LastName { get; set; }
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        public string Position { get; set; }
    }

}
