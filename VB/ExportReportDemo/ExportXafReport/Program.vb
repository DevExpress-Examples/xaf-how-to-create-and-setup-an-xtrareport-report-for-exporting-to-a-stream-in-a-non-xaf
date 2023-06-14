Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp.DC.Xpo
Imports DevExpress.ExpressApp.ReportsV2
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.XtraReports.UI
Imports ExportReportDemo.Module.BusinessObjects

Namespace ExportXafReport

    Friend Class Program

        Const connectionString As String = "Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\v11.0;Initial Catalog=ExportReportDemo"

        Shared Sub Main(ByVal args As String())
            Using objectSpaceProvider As XPObjectSpaceProvider = CreateObjectSpaceProvider()
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
            typesInfo.RegisterEntity(GetType(Employee))
            typesInfo.RegisterEntity(GetType(ReportDataV2))
        End Sub

        Private Shared Function CreateObjectSpaceProvider() As XPObjectSpaceProvider
            Call XpoTypesInfoHelper.ForceInitialize()
            Dim typesInfo As ITypesInfo = XpoTypesInfoHelper.GetTypesInfo()
            Dim xpoTypeInfoSource As XpoTypeInfoSource = XpoTypesInfoHelper.GetXpoTypeInfoSource()
            RegisterBOTypes(typesInfo)
            Dim dataStoreProvider As ConnectionStringDataStoreProvider = New ConnectionStringDataStoreProvider(connectionString)
            Return New XPObjectSpaceProvider(dataStoreProvider, typesInfo, xpoTypeInfoSource)
        End Function
    End Class
End Namespace
