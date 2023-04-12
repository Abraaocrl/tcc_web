using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TCC_WEB.Pages
{
    public class LoginModel : PageModel
    {
        private LinkGenerator linkGenerator;
        public string UriHomePage { get; set; }

        public LoginModel(LinkGenerator linkGenerator)
        {
            this.linkGenerator = linkGenerator;
        }

        public void OnGet()
        {
            UriHomePage = linkGenerator.GetUriByPage(this.HttpContext, page: "Home");
        }
    }
}
