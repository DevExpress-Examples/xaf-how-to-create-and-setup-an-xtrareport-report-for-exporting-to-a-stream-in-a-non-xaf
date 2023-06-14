using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.Base.ReportsV2;

namespace ExportXafReport
{
    public class MyReportDataSourceHelper : ReportDataSourceHelper
    {
        IObjectSpaceProvider objectSpaceProvider;
        public MyReportDataSourceHelper(IObjectSpaceProvider objectSpaceProvider)
            : base(null)
        {
            this.objectSpaceProvider = objectSpaceProvider;
        }
        protected override IReportObjectSpaceProvider CreateReportObjectSpaceProvider()
        {
            return new MyReportObjectSpaceProvider(objectSpaceProvider);
        }
    }
}
