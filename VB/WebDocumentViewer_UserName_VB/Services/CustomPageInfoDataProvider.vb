Imports DevExpress.XtraPrinting

Friend Class CustomPageInfoDataProvider
	Inherits PageInfoDataProviderBase

	Private ReadOnly httpContext As HttpContext
	Public Sub New(ByVal httpContext As HttpContext)
		Me.httpContext = httpContext
	End Sub

	Public Overrides Function GetText(ByVal ps As PrintingSystemBase,
									  ByVal brick As PageInfoTextBrickBase) As String
		If brick.PageInfo <> PageInfo.UserName Then
			Return Nothing
		End If
		If httpContext Is Nothing Then
			Return "<No Information>"
		End If
		Dim user = httpContext.User
		If user Is Nothing OrElse user.Identity Is Nothing Then
			Return "<Please enable Forms or Windows security>"
		End If
		Dim identity = user.Identity
		Return If(identity.IsAuthenticated, identity.Name, "<Guest>")
	End Function
End Class