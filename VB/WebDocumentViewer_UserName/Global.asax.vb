Imports System
Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Routing
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports WebDocumentViewer_UserName.Services

Namespace WebDocumentViewer_UserName

    ' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    ' visit http://go.microsoft.com/?LinkId=9394801
    Public Class MvcApplication
        Inherits Web.HttpApplication

        Protected Sub Application_Start()
            Native.WebDocumentViewerBootstrapper.SessionState = Web.SessionState.SessionStateBehavior.ReadOnly
            Call AreaRegistration.RegisterAllAreas()
            Call GlobalConfiguration.Configure(New Action(Of HttpConfiguration)(AddressOf Register))
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
            RouteConfig.RegisterRoutes(RouteTable.Routes)
            ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()
            AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
            Call DefaultWebDocumentViewerContainer.Register(Of WebDocumentViewerOperationLogger, CustomWebDocumentViewerOperationLogger)()
        End Sub

        Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
            Dim exception As Exception = Server.GetLastError()
        'TODO: Handle Exception
        End Sub
    End Class
End Namespace
