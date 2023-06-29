using Aqua.EnumerableExtensions;
using DevExpress.ExpressApp.Core;
using DevExpress.ExpressApp.Core.Services;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl.EF;
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

            var typesInfo = serviceProvider.GetRequiredService<ITypesInfo>();
            InitTypesInfo(typesInfo, serviceProvider.GetRequiredService<IObjectSpaceProviderFactory>());
            RegisterBOTypes(typesInfo);

            IReportExportService reportExportService = serviceProvider.GetRequiredService<IReportExportService>();
            using var report = reportExportService.LoadReport<ReportDataV2>(data => data.DisplayName == "Employees Report");
            reportExportService.SetupReport(report);
            report.ExportToPdf("testEFCore.pdf");

            Console.WriteLine("Done");
        }
        static void InitTypesInfo(ITypesInfo typesInfo, IObjectSpaceProviderFactory osProviderFactory) {
            var osProviders = osProviderFactory.CreateObjectSpaceProviders();
            osProviders.ForEach(osProvider => ((TypesInfo)typesInfo).AddEntityStore(osProvider.EntityStore));
        }
        static void RegisterBOTypes(ITypesInfo typesInfo) {
            typesInfo.RegisterEntity(typeof(Employee));
        }
    }
}