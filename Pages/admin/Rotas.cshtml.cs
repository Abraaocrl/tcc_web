using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace TCC_WEB.Pages.admin
{
    public class RotasModel : PageModel
    {
        private LinkGenerator linkGenerator;
        public string UriRotaEdicaoPage { get; set; }

        public RotasModel(LinkGenerator linkGenerator)
        {
            this.linkGenerator = linkGenerator;
        }

        public void OnGet()
        {
            this.UriRotaEdicaoPage = linkGenerator.GetPathByPage(this.HttpContext, page: "Rotas_Edit", values: new { id = 0 });
        }
    }
}
