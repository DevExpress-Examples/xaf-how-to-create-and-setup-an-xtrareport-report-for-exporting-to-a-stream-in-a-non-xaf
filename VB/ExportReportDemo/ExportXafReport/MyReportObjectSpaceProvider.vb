Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ReportsV2
Imports DevExpress.Persistent.Base.ReportsV2
Imports System

Namespace ExportXafReport

    Public Class MyReportObjectSpaceProvider
        Implements IReportObjectSpaceProvider, IObjectSpaceCreator

        Private objectSpaceProvider As IObjectSpaceProvider

        Private objectSpace As IObjectSpace

        Public Sub New(ByVal objectSpaceProvider As IObjectSpaceProvider)
            Me.objectSpaceProvider = objectSpaceProvider
        End Sub

        Public Sub DisposeObjectSpaces() Implements IReportObjectSpaceProvider.DisposeObjectSpaces
            If objectSpace IsNot Nothing Then
                objectSpace.Dispose()
                objectSpace = Nothing
            End If
        End Sub

        Public Function GetObjectSpace(ByVal type As Type) As IObjectSpace Implements IReportObjectSpaceProvider.GetObjectSpace
            If objectSpace Is Nothing Then
                objectSpace = objectSpaceProvider.CreateObjectSpace()
            End If

            Return objectSpace
        End Function

        Public Function CreateObjectSpace(ByVal type As Type) As IObjectSpace Implements IObjectSpaceCreator.CreateObjectSpace
            Return objectSpaceProvider.CreateObjectSpace()
        End Function
    End Class
End Namespace
