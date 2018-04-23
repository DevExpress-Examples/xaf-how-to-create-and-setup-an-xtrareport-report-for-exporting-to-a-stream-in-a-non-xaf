using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.EF;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.XtraReports.UI;
using ExportReportDemoEF.Module.BusinessObjects;

namespace ExportXafReport
{
    class Program
    {
        const string connectionString = @"Integrated Security=SSPI;Pooling=false;MultipleActiveResultSets=True;Data Source=(localdb)\v11.0;Initial Catalog=ExportReportDemoEF";
        static void Main(string[] args)
        {
            using (EFObjectSpaceProvider objectSpaceProvider = CreateObjectSpaceProvider())
            {
                IObjectSpace objectSpace = objectSpaceProvider.CreateObjectSpace();
                ReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "Employees Report"));
                ExportReport(reportData, objectSpaceProvider);
            }
        }
        private static void ExportReport(IReportDataV2 reportData, IObjectSpaceProvider objectSpaceProvider)
        {
            XtraReport report = ReportDataProvider.ReportsStorage.LoadReport(reportData);
            MyReportDataSourceHelper reportDataSourceHelper = new MyReportDataSourceHelper(objectSpaceProvider);
            ReportDataProvider.ReportObjectSpaceProvider = new MyReportObjectSpaceProvider(objectSpaceProvider);
            reportDataSourceHelper.SetupBeforePrint(report);
            report.ExportToPdf("test.pdf");
        }
        // register your application types here
        private static void RegisterBOTypes(ITypesInfo typesInfo)
        {
            typesInfo.RegisterEntity(typeof(Employee));
        }
        private static EFObjectSpaceProvider CreateObjectSpaceProvider()
        {
            EFObjectSpaceProvider objectSpaceProvider = new EFObjectSpaceProvider(typeof(ExportReportDemoEFDbContext), connectionString);
            ((TypesInfo)XafTypesInfo.Instance).AddEntityStore(objectSpaceProvider.EntityStore);
            RegisterBOTypes(XafTypesInfo.Instance);
            return objectSpaceProvider;
        }
    }
}
