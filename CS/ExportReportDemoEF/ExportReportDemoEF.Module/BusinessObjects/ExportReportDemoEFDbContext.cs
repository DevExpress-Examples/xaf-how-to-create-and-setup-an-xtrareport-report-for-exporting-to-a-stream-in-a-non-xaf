using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;

namespace  ExportReportDemoEF.Module.BusinessObjects {
	public class ExportReportDemoEFDbContext : DbContext {
		public ExportReportDemoEFDbContext(String connectionString)
			: base(connectionString) {
		}
		public ExportReportDemoEFDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
		public DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}