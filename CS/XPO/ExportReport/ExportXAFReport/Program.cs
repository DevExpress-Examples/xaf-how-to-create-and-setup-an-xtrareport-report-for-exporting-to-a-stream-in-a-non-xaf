using DevExpress.ExpressApp.Core;
using DevExpress.ExpressApp.Core.Services;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using ExportReportDemo.Module.BusinessObjects;
using Microsoft.Extensions.DependencyInjection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            ServiceCollection serviceDescriptors = new ServiceCollection();
            serviceDescriptors.AddXafCore();
            serviceDescriptors.AddXafReportingCore();
            serviceDescriptors.AddScoped<IObjectSpaceProviderFactory, CustomObjectSpaceProviderFactory>();

            IServiceProvider serviceProvider = serviceDescriptors.BuildServiceProvider();

            RegisterBOTypes(serviceProvider.GetRequiredService<ITypesInfo>());

            IReportExportService reportExportService = serviceProvider.GetRequiredService<IReportExportService>();
            using var report = reportExportService.LoadReport<ReportDataV2>(data => data.DisplayName == "Employees Report");
            reportExportService.SetupReport(report);
            report.ExportToPdf("testXPO.pdf");

            Console.WriteLine("Done");
        }
        static void RegisterBOTypes(ITypesInfo typesInfo) {
            XpoTypesInfoHelper.ForceInitialize();
            typesInfo.RegisterEntity(typeof(Employee));
            typesInfo.RegisterEntity(typeof(ReportDataV2));
        }
    }
}