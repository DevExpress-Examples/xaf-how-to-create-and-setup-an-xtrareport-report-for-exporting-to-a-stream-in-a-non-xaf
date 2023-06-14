Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp.EF
Imports DevExpress.ExpressApp.ReportsV2
Imports DevExpress.Persistent.BaseImpl.EF
Imports DevExpress.XtraReports.UI
Imports ExportReportDemoEF.Module.BusinessObjects

Namespace ExportXafReport

    Friend Class Program

        Const connectionString As String = "Integrated Security=SSPI;Pooling=false;MultipleActiveResultSets=True;Data Source=(localdb)\v11.0;Initial Catalog=ExportReportDemoEF"

        Shared Sub Main(ByVal args As String())
            Using objectSpaceProvider As EFObjectSpaceProvider = CreateObjectSpaceProvider()
                Dim objectSpace As IObjectSpace = objectSpaceProvider.CreateObjectSpace()
                Dim reportData As ReportDataV2 = objectSpace.FindObject(Of ReportDataV2)(New BinaryOperator("DisplayName", "Employees Report"))
                ExportReport(reportData, objectSpaceProvider)
            End Using
        End Sub

        Private Shared Sub ExportReport(ByVal reportData As IReportDataV2, ByVal objectSpaceProvider As IObjectSpaceProvider)
            Dim report As XtraReport = ReportDataProvider.ReportsStorage.LoadReport(reportData)
            Dim reportDataSourceHelper As MyReportDataSourceHelper = New MyReportDataSourceHelper(objectSpaceProvider)
            ReportDataProvider.ReportObjectSpaceProvider = New MyReportObjectSpaceProvider(objectSpaceProvider)
            reportDataSourceHelper.SetupBeforePrint(report)
            report.ExportToPdf("test.pdf")
        End Sub

        ' register your application types here
        Private Shared Sub RegisterBOTypes(ByVal typesInfo As ITypesInfo)
            typesInfo.RegisterEntity(GetType(ExportReportDemoEF.Module.BusinessObjects.Employee))
        End Sub

        Private Shared Function CreateObjectSpaceProvider() As EFObjectSpaceProvider
            Dim objectSpaceProvider As EFObjectSpaceProvider = New EFObjectSpaceProvider(GetType(ExportReportDemoEF.[Module].BusinessObjects.ExportReportDemoEFDbContext), connectionString)
            Call CType(XafTypesInfo.Instance, TypesInfo).AddEntityStore(objectSpaceProvider.EntityStore)
            RegisterBOTypes(XafTypesInfo.Instance)
            Return objectSpaceProvider
        End Function
    End Class
End Namespace
