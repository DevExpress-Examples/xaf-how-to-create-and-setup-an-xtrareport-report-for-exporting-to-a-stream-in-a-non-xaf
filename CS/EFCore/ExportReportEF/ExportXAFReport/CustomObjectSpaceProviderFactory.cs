using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Core;
using DevExpress.ExpressApp.EFCore;
using ExportReportEF.Module.BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class CustomObjectSpaceProviderFactory : IObjectSpaceProviderFactory {
        const string connectionString = @"Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\mssqllocaldb;Initial Catalog=ExportReportEF";
        public IEnumerable<IObjectSpaceProvider> CreateObjectSpaceProviders() {
            return new IObjectSpaceProvider[] {
                new EFCoreObjectSpaceProvider<ExportReportEFEFCoreDbContext>((builder, _) => { builder.UseSqlServer(connectionString).UseChangeTrackingProxies(); })
            };
        }
    }
}