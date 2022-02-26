using System;
using System.Web;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;

class CustomWebDocumentViewerOperationLogger : WebDocumentViewerOperationLogger
{
    public override Action BuildStarting(string reportId, XtraReport report, ReportBuildProperties buildProperties)
    {
        var httpContext = HttpContext.Current;
        return () => GenerateBuildStatingAction(report, httpContext);
    }

    static void GenerateBuildStatingAction(XtraReport report, HttpContext httpContext)
    {
        report.PrintingSystem.AddService(typeof(PageInfoDataProviderBase), new CustomPageInfoDataProvider(httpContext));
    }
}