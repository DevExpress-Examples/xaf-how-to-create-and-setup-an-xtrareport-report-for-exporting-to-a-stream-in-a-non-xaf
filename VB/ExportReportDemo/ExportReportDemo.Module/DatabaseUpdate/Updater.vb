Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Updating
Imports ExportReportDemo.Module.BusinessObjects

Namespace ExportReportDemo.Module.DatabaseUpdate

    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub

        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            CreateEmployees()
        End Sub

        Private Sub CreateEmployees()
            AddEmployee("Andrew", "Fuller", "Sales Manager")
            AddEmployee("Mary", "Telitson", "Developer")
            AddEmployee("Michael", "Suyama", "Developer")
            AddEmployee("Nancy", "Davolio", "Developer")
            AddEmployee("Robert", "King", "Senior Developer")
            AddEmployee("Steven", "Buchanan", "Developer")
        End Sub

        Private Sub AddEmployee(ByVal name As String, ByVal lastName As String, ByVal position As String)
            Dim employee As Employee = ObjectSpace.FindObject(Of Employee)(CriteriaOperator.Parse(String.Format("FirstName == '{0}' && LastName == '{1}'", name, lastName)))
            If employee Is Nothing Then
                employee = ObjectSpace.CreateObject(Of Employee)()
                employee.FirstName = name
                employee.LastName = lastName
                employee.Position = position
            End If
        End Sub
    End Class
End Namespace
