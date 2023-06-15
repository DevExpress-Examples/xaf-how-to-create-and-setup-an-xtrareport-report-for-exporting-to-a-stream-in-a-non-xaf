using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.EFCore;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.XtraReports.UI;
using ExportReportDemo.Module.BusinessObjects;
using ExportReportEF.Module.BusinessObjects;
using ExportXafReport;
using Microsoft.EntityFrameworkCore;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        const string connectionString = @"Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\mssqllocaldb;Initial Catalog=ExportReportEF";
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            using (EFCoreObjectSpaceProvider<ExportReportEFEFCoreDbContext> objectSpaceProvider = CreateObjectSpaceProvider()) {
                IObjectSpace objectSpace = objectSpaceProvider.CreateObjectSpace();
                ReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "Employees Report"));
                ExportReport(reportData, objectSpaceProvider);
            }

            Console.WriteLine("Done");

        }
        private static EFCoreObjectSpaceProvider<ExportReportEFEFCoreDbContext> CreateObjectSpaceProvider() {
            EFCoreObjectSpaceProvider<ExportReportEFEFCoreDbContext> objectSpaceProvider = new EFCoreObjectSpaceProvider<ExportReportEFEFCoreDbContext>(
                (builder, _) => {builder.UseSqlServer(connectionString).UseChangeTrackingProxies();}
                );
            ((TypesInfo)XafTypesInfo.Instance).AddEntityStore(objectSpaceProvider.EntityStore);
            RegisterBOTypes(XafTypesInfo.Instance);
            return objectSpaceProvider;
        }

        private static void RegisterBOTypes(ITypesInfo typesInfo) {
            typesInfo.RegisterEntity(typeof(Employee));
        }

        private static void ExportReport(IReportDataV2 reportData, IObjectSpaceProvider objectSpaceProvider) {
            XtraReport report = ReportDataProvider.ReportsStorage.LoadReport(reportData);
            MyReportDataSourceHelper reportDataSourceHelper = new MyReportDataSourceHelper(objectSpaceProvider);
            ReportDataProvider.ReportObjectSpaceProvider = new MyReportObjectSpaceProvider(objectSpaceProvider);
            reportDataSourceHelper.SetupBeforePrint(report);
            report.ExportToPdf("testEF.pdf");
        }

    }
}
