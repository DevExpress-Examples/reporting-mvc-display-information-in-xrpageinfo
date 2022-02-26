<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TestReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrPageInfo1})
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Name = "Detail"
        '
        'xrLabel1
        '
        Me.xrLabel1.BorderColor = System.Drawing.Color.DarkRed
        Me.xrLabel1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrLabel1.BorderWidth = 3.0!
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(79.79164!, 39.16667!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(128.125!, 35.49998!)
        Me.xrLabel1.StylePriority.UseBorderColor = False
        Me.xrLabel1.StylePriority.UseBorders = False
        Me.xrLabel1.StylePriority.UseBorderWidth = False
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "User Name:"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.BorderColor = System.Drawing.Color.DarkRed
        Me.xrPageInfo1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrPageInfo1.BorderWidth = 3.0!
        Me.xrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(207.9166!, 39.16667!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.UserName
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(368.875!, 35.49998!)
        Me.xrPageInfo1.StylePriority.UseBorderColor = False
        Me.xrPageInfo1.StylePriority.UseBorders = False
        Me.xrPageInfo1.StylePriority.UseBorderWidth = False
        Me.xrPageInfo1.StylePriority.UseFont = False
        '
        'TestReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Version = "21.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
End Class
