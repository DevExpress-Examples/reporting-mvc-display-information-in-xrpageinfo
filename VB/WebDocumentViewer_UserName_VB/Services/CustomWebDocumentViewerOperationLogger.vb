Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Friend Class CustomWebDocumentViewerOperationLogger
    Inherits WebDocumentViewerOperationLogger

    Public Overrides Function BuildStarting(ByVal reportId As String,
                                            ByVal report As XtraReport,
                                            ByVal buildProperties As ReportBuildProperties) As Action
        Dim httpContext = System.Web.HttpContext.Current
        Return Sub() GenerateBuildStatingAction(report, httpContext)
    End Function

    Private Shared Sub GenerateBuildStatingAction(ByVal report As XtraReport,
                                                  ByVal httpContext As HttpContext)
        report.PrintingSystem.AddService(GetType(PageInfoDataProviderBase),
                                         New CustomPageInfoDataProvider(httpContext))
    End Sub
End Class
