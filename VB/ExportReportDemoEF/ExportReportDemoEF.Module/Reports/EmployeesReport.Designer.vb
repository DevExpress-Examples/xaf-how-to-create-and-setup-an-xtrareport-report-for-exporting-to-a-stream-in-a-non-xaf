Namespace ExportReportDemoEF.Module.Reports
    Partial Public Class EmployeesReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.collectionDataSource1 = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            DirectCast(Me.collectionDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel4, Me.xrLine1})
            Me.Detail.HeightF = 56F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' collectionDataSource1
            ' 
            Me.collectionDataSource1.Name = "collectionDataSource1"
            Me.collectionDataSource1.ObjectTypeName = "ExportReportDemoEF.Module.BusinessObjects.Employee"
            Me.collectionDataSource1.TopReturnedRecords = 0
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 9F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel1.StyleName = "FieldCaption"
            Me.xrLabel1.Text = "Full Name"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6F, 33F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel2.StyleName = "FieldCaption"
            Me.xrLabel2.Text = "Position"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FullName")})
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(174F, 9F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel3.StyleName = "DataField"
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Position")})
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(174F, 33F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel4.StyleName = "DataField"
            Me.xrLabel4.Text = "xrLabel4"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 3F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(638F, 2F)
            ' 
            ' pageFooterBand1
            ' 
            Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
            Me.pageFooterBand1.HeightF = 29F
            Me.pageFooterBand1.Name = "pageFooterBand1"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo1.StyleName = "PageInfo"
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Format = "Page {0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo2.StyleName = "PageInfo"
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5})
            Me.reportHeaderBand1.HeightF = 61F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(638F, 43F)
            Me.xrLabel5.StyleName = "Title"
            Me.xrLabel5.Text = "Employees Report"
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Teal
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Black
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Arial", 9F)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Arial", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' EmployeesReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.pageFooterBand1, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.DataSource = Me.collectionDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "14.2"
            DirectCast(Me.collectionDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Protected collectionDataSource1 As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    End Class
End Namespace
