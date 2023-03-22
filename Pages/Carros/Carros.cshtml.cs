using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TCC_WEB.Pages
{
    public class CarrosModel : PageModel
    {
        private readonly ILogger<CarrosModel> _logger;

        public CarrosModel(ILogger<CarrosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}