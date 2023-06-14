Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.EF
Imports ExportReportDemoEF.Module.BusinessObjects
Imports System.Data.Common

Namespace ExportReportDemoEF.Win

    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWinWinApplicationMembersTopicAll
    Public Partial Class ExportReportDemoEFWindowsFormsApplication
        Inherits WinApplication

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            If args.Connection IsNot Nothing Then
                args.ObjectSpaceProvider = New EFObjectSpaceProvider(GetType([Module].BusinessObjects.ExportReportDemoEFDbContext), TypesInfo, Nothing, CType(args.Connection, DbConnection))
            Else
                args.ObjectSpaceProvider = New EFObjectSpaceProvider(GetType([Module].BusinessObjects.ExportReportDemoEFDbContext), TypesInfo, Nothing, args.ConnectionString)
            End If
        End Sub

        Private Sub ExportReportDemoEFWindowsFormsApplication_CustomizeLanguagesList(ByVal sender As Object, ByVal e As CustomizeLanguagesListEventArgs)
            Dim userLanguageName As String = Threading.Thread.CurrentThread.CurrentUICulture.Name
            If Not Equals(userLanguageName, "en-US") AndAlso e.Languages.IndexOf(userLanguageName) = -1 Then
                e.Languages.Add(userLanguageName)
            End If
        End Sub

        Private Sub ExportReportDemoEFWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DatabaseVersionMismatchEventArgs)
#If EASYTEST
            e.Updater.Update();
            e.Handled = true;
#Else
            If System.Diagnostics.Debugger.IsAttached Then
                e.Updater.Update()
                e.Handled = True
            Else
                Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Microsoft.VisualBasic.Constants.vbCrLf & "This error occurred  because the automatic database update was disabled when the application was started without debugging." & Microsoft.VisualBasic.Constants.vbCrLf & "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database using the 'DBUpdater' tool." & Microsoft.VisualBasic.Constants.vbCrLf & "Anyway, refer to the 'Update Application and Database Versions' help topic at http://help.devexpress.com/#Xaf/CustomDocument2795 " & "for more detailed information. If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/")
            End If
#End If
        End Sub
    End Class
End Namespace
