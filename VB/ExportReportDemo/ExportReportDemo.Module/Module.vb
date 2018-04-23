Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.DC
Imports System.Collections.Generic
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.ReportsV2
Imports ExportReportDemo.Module.BusinessObjects
Imports ExportReportDemo.Module.Reports

Namespace ExportReportDemo.Module
    Public NotInheritable Partial Class ExportReportDemoModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
            BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Dim predefinedReportsUpdater As New PredefinedReportsUpdater(Application, objectSpace, versionFromDB)
            predefinedReportsUpdater.AddPredefinedReport(Of EmployeesReport)("Employees Report", GetType(Employee), True)
            Return New ModuleUpdater() { updater, predefinedReportsUpdater }
        End Function
        Public Overrides Sub Setup(ByVal application As XafApplication)
            MyBase.Setup(application)
        End Sub
        Public Overrides Sub CustomizeTypesInfo(ByVal typesInfo As ITypesInfo)
            MyBase.CustomizeTypesInfo(typesInfo)
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo)
        End Sub
    End Class
End Namespace
