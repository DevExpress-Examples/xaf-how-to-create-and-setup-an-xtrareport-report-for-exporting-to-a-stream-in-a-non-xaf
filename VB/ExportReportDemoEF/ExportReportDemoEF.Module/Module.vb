Imports System
Imports System.Text
Imports System.Linq
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Model.Core
Imports DevExpress.ExpressApp.Model.DomainLogics
Imports DevExpress.ExpressApp.Model.NodeGenerators
Imports System.Data.Entity
Imports ExportReportDemoEF.Module.BusinessObjects
Imports DevExpress.ExpressApp.ReportsV2
Imports ExportReportDemoEF.Module.Reports

Namespace ExportReportDemoEF.Module
    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppModuleBasetopic.
    Public NotInheritable Partial Class ExportReportDemoEFModule
        Inherits ModuleBase

        ' Uncomment this code to delete and recreate the database each time the data model has changed.
        ' Do not use this code in a production environment to avoid data loss.
        ' #if DEBUG
        ' static ExportReportDemoEFModule() {
        '     Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ExportReportDemoEFDbContext>());
        ' }
        ' #endif 
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Dim predefinedReportsUpdater As New PredefinedReportsUpdater(Application, objectSpace, versionFromDB)
            predefinedReportsUpdater.AddPredefinedReport(Of EmployeesReport)("Employees Report", GetType(Employee), True)
            Return New ModuleUpdater() { updater, predefinedReportsUpdater }
        End Function
        Public Overrides Sub Setup(ByVal application As XafApplication)
            MyBase.Setup(application)
            ' Manage various aspects of the application UI and behavior at the module level.
        End Sub
        Public Overrides Sub Setup(ByVal moduleManager As ApplicationModulesManager)
            MyBase.Setup(moduleManager)
            Dim reportModule As ReportsModuleV2 = moduleManager.Modules.FindModule(Of ReportsModuleV2)()
            reportModule.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.EF.ReportDataV2)
        End Sub
    End Class
End Namespace
