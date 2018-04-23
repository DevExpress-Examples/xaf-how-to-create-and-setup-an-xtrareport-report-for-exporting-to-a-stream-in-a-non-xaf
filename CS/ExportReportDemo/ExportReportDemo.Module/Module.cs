using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.ReportsV2;
using ExportReportDemo.Module.BusinessObjects;
using ExportReportDemo.Module.Reports;

namespace ExportReportDemo.Module {
    public sealed partial class ExportReportDemoModule : ModuleBase {
        public ExportReportDemoModule() {
            InitializeComponent();
			BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction;
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            PredefinedReportsUpdater predefinedReportsUpdater = new PredefinedReportsUpdater(Application, objectSpace, versionFromDB);
            predefinedReportsUpdater.AddPredefinedReport<EmployeesReport>("Employees Report", typeof(Employee), true);
            return new ModuleUpdater[] { updater, predefinedReportsUpdater };
        }
        public override void Setup(XafApplication application) {
            base.Setup(application);
        }
		public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
			base.CustomizeTypesInfo(typesInfo);
			CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);
		}
    }
}
