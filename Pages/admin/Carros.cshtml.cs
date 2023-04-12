using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TCC_WEB.Pages
{
    public class CarrosModel : PageModel
    {
        private LinkGenerator linkGenerator;
        public string UriCarrosEdicaoPage { get; set; }
        private readonly ILogger<CarrosModel> _logger;

        public CarrosModel(ILogger<CarrosModel> logger, LinkGenerator linkGenerator)
        {
            _logger = logger;
            this.linkGenerator = linkGenerator;
        }

        public void OnGet()
        {
            this.UriCarrosEdicaoPage = linkGenerator.GetPathByPage(this.HttpContext, page: "Carros_Edit", values: new { id = 0 });
        }
    }
}