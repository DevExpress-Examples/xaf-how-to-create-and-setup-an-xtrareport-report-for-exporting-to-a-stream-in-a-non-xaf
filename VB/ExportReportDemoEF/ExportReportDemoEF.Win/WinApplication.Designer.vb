Namespace ExportReportDemoEF.Win

    Partial Class ExportReportDemoEFWindowsFormsApplication

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New ExportReportDemoEF.[Module].ExportReportDemoEFModule()
            Me.module4 = New ExportReportDemoEF.[Module].Win.ExportReportDemoEFWindowsFormsModule()
            Me.reportsModuleV2 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
            Me.reportsWindowsFormsModuleV2 = New DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            '
            ' reportsModuleV2
            '
            Me.reportsModuleV2.EnableInplaceReports = True
            Me.reportsModuleV2.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.EF.ReportDataV2)
            Me.reportsModuleV2.ShowAdditionalNavigation = False
            ' 
            ' ExportReportDemoEFWindowsFormsApplication
            ' 
            Me.ApplicationName = "ExportReportDemoEF"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.reportsModuleV2)
            Me.Modules.Add(Me.reportsWindowsFormsModuleV2)
            AddHandler Me.DatabaseVersionMismatch, New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(AddressOf Me.ExportReportDemoEFWindowsFormsApplication_DatabaseVersionMismatch)
            AddHandler Me.CustomizeLanguagesList, New System.EventHandler(Of DevExpress.ExpressApp.CustomizeLanguagesListEventArgs)(AddressOf Me.ExportReportDemoEFWindowsFormsApplication_CustomizeLanguagesList)
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule

        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule

        Private module3 As ExportReportDemoEF.[Module].ExportReportDemoEFModule

        Private module4 As ExportReportDemoEF.[Module].Win.ExportReportDemoEFWindowsFormsModule

        Private reportsModuleV2 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2

        Private reportsWindowsFormsModuleV2 As DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2
    End Class
End Namespace
