using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Core;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Xpo;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class CustomObjectSpaceProviderFactory : IObjectSpaceProviderFactory {
        const string connectionString = @"Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\mssqllocaldb;Initial Catalog=ExportReport";
        readonly ConnectionStringDataStoreProvider dataStoreProvider = new ConnectionStringDataStoreProvider(connectionString);
        readonly ITypesInfo typesInfo;
        public CustomObjectSpaceProviderFactory(ITypesInfo typesInfo) {
            this.typesInfo = typesInfo;
        }
        public IEnumerable<IObjectSpaceProvider> CreateObjectSpaceProviders() {
            return new IObjectSpaceProvider[] { new XPObjectSpaceProvider(dataStoreProvider, typesInfo, XpoTypesInfoHelper.GetXpoTypeInfoSource()) };
        }
    }
}