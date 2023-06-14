using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC.Xpo;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using System;
using ExportReportDemo.Module.BusinessObjects;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.XtraReports.UI;
using ExportXafReport;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        const string connectionString = @"Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\mssqllocaldb;Initial Catalog=ExportReport";
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            DevExpress.ExpressApp.FrameworkSettings.DefaultSettingsCompatibilityMode = DevExpress.ExpressApp.FrameworkSettingsCompatibilityMode.v20_1;
            using (XPObjectSpaceProvider objectSpaceProvider = CreateObjectSpaceProvider()) {
                IObjectSpace objectSpace = objectSpaceProvider.CreateObjectSpace();
                ReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "Employees Report"));
                ExportReport(reportData, objectSpaceProvider);
            }
        }
        private static XPObjectSpaceProvider CreateObjectSpaceProvider() {
            XpoTypesInfoHelper.ForceInitialize();
            ITypesInfo typesInfo = XpoTypesInfoHelper.GetTypesInfo();
            XpoTypeInfoSource xpoTypeInfoSource = XpoTypesInfoHelper.GetXpoTypeInfoSource();
            RegisterBOTypes(typesInfo);
            ConnectionStringDataStoreProvider dataStoreProvider = new ConnectionStringDataStoreProvider(connectionString);
            return new XPObjectSpaceProvider(dataStoreProvider, typesInfo, xpoTypeInfoSource);
        }
        private static void RegisterBOTypes(ITypesInfo typesInfo) {
            typesInfo.RegisterEntity(typeof(Employee));
            typesInfo.RegisterEntity(typeof(ReportDataV2));
        }
        private static void ExportReport(IReportDataV2 reportData, IObjectSpaceProvider objectSpaceProvider) {
            XtraReport report = ReportDataProvider.ReportsStorage.LoadReport(reportData);
            MyReportDataSourceHelper reportDataSourceHelper = new MyReportDataSourceHelper(objectSpaceProvider);
            ReportDataProvider.ReportObjectSpaceProvider = new MyReportObjectSpaceProvider(objectSpaceProvider);
            reportDataSourceHelper.SetupBeforePrint(report);
            report.ExportToPdf("test123.pdf");
        }
    }
}