<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597009/21.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T484189)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for Web (ASP.NET MVC) - How to Display the Name of the Current Logged in User in a Report

This example demonstrates how to use the [PageInfoDataProviderBase](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PageInfoDataProviderBase) service to display information in the [XRPageInfo](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRPageInfo) control.

## Implementation Details

### Disable Caching

The WebDocumentViewer extension uses the **CachedDocumentSource** component to store the document and improve document rendering performance. An XtraReport instance, passed to the WebDocumentViewer Bind method, is disposed of, so any services or events that affect the export result (the **PageInfoDataProviderBase** service in this case) are detached from the report/document. 

You should call the **DefaultWebDocumentViewerContainer.DisableCachedDocumentSource** method at application startup to disable caching.

### Register the WebDocumentViewerOperationLogger Service

To configure a report before document creation, create the [WebDocumentViewerOperationLogger](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogger) class descendant and add an instance of this class to the [DefaultWebDocumentViewerContainer](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer) at application startup. The WebDocumentViewerOperationLogger service passes the [HttpContext](https://docs.microsoft.com/en-us/dotnet/api/system.web.httpcontext) instance for the current HTTP request to the **PageInfoDataProviderBase** service.

### Implement the PageInfoDataProviderBase Service

To change the default display text of the [XRPageInfo](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRPageInfo) control, add a custom [PageInfoDataProviderBase](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PageInfoDataProviderBase) service to the [XtraReport.PrintingSystem](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.PrintingSystem). 

Add the code that analyzes the HttpContext and returns the text for display in the **XRPageInfo** control to the [PageInfoDataProviderBase.GetText](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PageInfoDataProviderBase.GetText(DevExpress.XtraPrinting.PrintingSystemBase-DevExpress.XtraPrinting.PageInfoTextBrickBase)) method.

## Files to Look At

- [Global.asax.cs](CS/WebDocumentViewer_UserName/Global.asax.cs#L22-L23) ([Global.asax.vb](VB/WebDocumentViewer_UserName_VB/Global.asax.vb#L22-L23))
- [CustomWebDocumentViewerOperationLogger.cs](CS/WebDocumentViewer_UserName/Services/CustomWebDocumentViewerOperationLogger.cs) ([CustomWebDocumentViewerOperationLogger.vb](VB/WebDocumentViewer_UserName_VB/Services/CustomWebDocumentViewerOperationLogger.vb))
- [CustomPageInfoDataProvider.cs](CS/WebDocumentViewer_UserName/Services/CustomPageInfoDataProvider.cs) ([CustomPageInfoDataProvider.vb](VB/WebDocumentViewer_UserName_VB/Services/CustomPageInfoDataProvider.vb))

## Documentation

- [XRPageInfo Control](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRPageInfo)
- [Display the Current Date and Time in a Report](https://docs.devexpress.com/XtraReports/5291/detailed-guide-to-devexpress-reporting/add-extra-information/display-the-current-date-and-time-in-a-report)
- [Display the User Name in a Report](https://docs.devexpress.com/XtraReports/5292/detailed-guide-to-devexpress-reporting/add-extra-information/display-the-user-name-in-a-report)

## Related SC Tickets
- [How to use client timezone in a report's PageInfo](https://supportcenter.devexpress.com/ticket/details/t1056171/how-to-use-client-timezone-in-a-report-s-pageinfo)
- [XRPageInfo: How to provide custom page numbering for a merged report](https://supportcenter.devexpress.com/ticket/details/t512092/xrpageinfo-how-to-provide-custom-page-numbering-for-a-merged-report)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-mvc-display-information-in-xrpageinfo&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-mvc-display-information-in-xrpageinfo&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
