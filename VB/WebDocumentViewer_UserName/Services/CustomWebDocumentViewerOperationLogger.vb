Imports System
Imports System.Web
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace WebDocumentViewer_UserName.Services

    Friend Class CustomWebDocumentViewerOperationLogger
        Inherits WebDocumentViewerOperationLogger

        Public Overrides Function BuildStarting(ByVal reportId As String, ByVal report As XtraReport, ByVal buildProperties As ReportBuildProperties) As Action
            Dim httpContext = Web.HttpContext.Current
            Return Sub() GenerateBuildStatingAction(report, httpContext)
        End Function

        Private Shared Sub GenerateBuildStatingAction(ByVal report As XtraReport, ByVal httpContext As HttpContext)
            report.PrintingSystem.AddService(GetType(PageInfoDataProviderBase), New CustomPageInfoDataProvider(httpContext))
        End Sub
    End Class
End Namespace
