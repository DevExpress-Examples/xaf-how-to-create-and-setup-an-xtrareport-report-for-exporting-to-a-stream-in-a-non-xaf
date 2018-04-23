using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.DC.Xpo;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using DevExpress.XtraReports.UI;
using ExportReportDemo.Module.BusinessObjects;

namespace ExportXafReport
{
    class Program
    {
        const string connectionString = @"Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\v11.0;Initial Catalog=ExportReportDemo";
        static void Main(string[] args)
        {
            using(XPObjectSpaceProvider objectSpaceProvider = CreateObjectSpaceProvider()) {
                IObjectSpace objectSpace = objectSpaceProvider.CreateObjectSpace();
                ReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "Employees Report"));
                ExportReport(reportData, objectSpaceProvider);
            }
        }
        private static void ExportReport(IReportDataV2 reportData, IObjectSpaceProvider objectSpaceProvider) {
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
            typesInfo.RegisterEntity(typeof(ReportDataV2));
        }
        private static XPObjectSpaceProvider CreateObjectSpaceProvider()
        {
            XpoTypesInfoHelper.ForceInitialize();
            ITypesInfo typesInfo = XpoTypesInfoHelper.GetTypesInfo();
            XpoTypeInfoSource xpoTypeInfoSource = XpoTypesInfoHelper.GetXpoTypeInfoSource();
            RegisterBOTypes(typesInfo);
            ConnectionStringDataStoreProvider dataStoreProvider = new ConnectionStringDataStoreProvider(connectionString);
            return new XPObjectSpaceProvider(dataStoreProvider, typesInfo, xpoTypeInfoSource);
        }
    }
}
