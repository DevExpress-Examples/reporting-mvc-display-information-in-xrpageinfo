<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597009/16.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T484189)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Global.asax.cs](./CS/WebDocumentViewer_UserName/Global.asax.cs) (VB: [Global.asax.vb](./VB/WebDocumentViewer_UserName/Global.asax.vb))
* [CustomPageInfoDataProvider.cs](./CS/WebDocumentViewer_UserName/Services/CustomPageInfoDataProvider.cs) (VB: [CustomPageInfoDataProvider.vb](./VB/WebDocumentViewer_UserName/Services/CustomPageInfoDataProvider.vb))
* **[CustomWebDocumentViewerOperationLogger.cs](./CS/WebDocumentViewer_UserName/Services/CustomWebDocumentViewerOperationLogger.cs) (VB: [CustomWebDocumentViewerOperationLogger.vb](./VB/WebDocumentViewer_UserName/Services/CustomWebDocumentViewerOperationLogger.vb))**
* [Index.cshtml](./CS/WebDocumentViewer_UserName/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to Display the Current Logged in User Name in the Report
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t484189/)**
<!-- run online end -->


To configure a report before document creation, add a <strong>WebDocumentViewerOperationLogger</strong> instance to the <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsWebWebDocumentViewerDefaultWebDocumentViewerContainertopic">DefaultWebDocumentViewerContainer</a>.<br>To change the default display text of <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRPageInfotopic">PageInfo</a>, add a custom <strong>PageInfoDataProviderBase</strong> service to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_PrintingSystemtopic">XtraReport.PrintingSystem</a>.

<br/>


