Imports System.Data.Entity
Imports System.Data.Common
Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity.Infrastructure
Imports System.ComponentModel
Imports DevExpress.ExpressApp.EF.Updating
Imports DevExpress.Persistent.BaseImpl.EF

Namespace ExportReportDemoEF.Module.BusinessObjects

    Public Class ExportReportDemoEFDbContext
        Inherits DbContext

        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString)
        End Sub

        Public Sub New(ByVal connection As DbConnection)
            MyBase.New(connection, False)
        End Sub

        Public Property ModulesInfo As DbSet(Of ModuleInfo)

        Public Property ReportDataV2 As DbSet(Of ReportDataV2)

        Public Property Employees As DbSet(Of Employee)
    End Class
End Namespace
