Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ReportsV2
Imports DevExpress.Persistent.Base.ReportsV2

Namespace ExportXafReport

    Public Class MyReportDataSourceHelper
        Inherits ReportDataSourceHelper

        Private objectSpaceProvider As IObjectSpaceProvider

        Public Sub New(ByVal objectSpaceProvider As IObjectSpaceProvider)
            MyBase.New(Nothing)
            Me.objectSpaceProvider = objectSpaceProvider
        End Sub

        Protected Overrides Function CreateReportObjectSpaceProvider() As IReportObjectSpaceProvider
            Return New MyReportObjectSpaceProvider(objectSpaceProvider)
        End Function
    End Class
End Namespace
