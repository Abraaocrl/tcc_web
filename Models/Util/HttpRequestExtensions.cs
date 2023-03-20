namespace TCC_WEB.Models.Util
{
    public static class HttpRequestExtensions
    {
        public static string? BaseUrl(this HttpRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var uriBuilder = new UriBuilder(request.Scheme,request.Host.Host,request.Host.Port ?? -1);
            if(uriBuilder.Uri.IsDefaultPort)
            {
                uriBuilder.Port = -1;
            }

            return uriBuilder.Uri.AbsoluteUri;
        }

        public static bool IsReleaseBuild()
        {
            #if DEBUG
                return false;
            #else
                return true;
            #endif
        }
    }
}
