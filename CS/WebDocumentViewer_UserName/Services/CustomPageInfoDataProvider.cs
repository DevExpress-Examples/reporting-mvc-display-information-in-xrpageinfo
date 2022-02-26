using System.Web;
using DevExpress.XtraPrinting;

class CustomPageInfoDataProvider : PageInfoDataProviderBase
{
    readonly HttpContext httpContext;
    public CustomPageInfoDataProvider(HttpContext httpContext)
    {
        this.httpContext = httpContext;
    }

    public override string GetText(PrintingSystemBase ps, PageInfoTextBrickBase brick)
    {
        if (brick.PageInfo != PageInfo.UserName)
        {
            return null;
        }
        if (httpContext == null)
            return "<No Information>";
        var user = httpContext.User;
        if (user == null || user.Identity == null)
            return "<Please enable Forms or Windows security>";
        var identity = user.Identity;
        return identity.IsAuthenticated
            ? identity.Name
            : "<Guest>";
    }
}