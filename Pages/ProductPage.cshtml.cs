using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pagemodelexample.Pages
{
    public class ProductPageModel : PageModel
    {
        private readonly ILogger<ProductPageModel> _logger;
        public ProductPageModel(ILogger<ProductPageModel> logger){
            _logger = logger;
        }

        //OnGet, OnPos, OnGetAbc... Http Request
        //void IActionResult
        public void OnGet()
        {
            if (Request.RouteValues["id"] != null){
                int id = int.Parse(Request.RouteValues["id"].ToString());
                ViewData["Title"] = $"Sản phẩm (ID = {id})";
            }else{
                ViewData["Title"] = $"Danh sach san pham";
            }
            
        }
    }
}
