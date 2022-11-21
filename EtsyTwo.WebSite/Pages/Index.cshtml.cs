using EtsyTwo.WebSite.Models;
using EtsyTwo.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EtsyTwo.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private JsonFileProductService _productService;
        public IEnumerable<Product> _products { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger, 
            JsonFileProductService jsonFileProductService)
        {
            _logger = logger;
            _productService = jsonFileProductService;
        }

        public void OnGet()
        {
             _products = _productService.GetProducts();
        }
    }
}