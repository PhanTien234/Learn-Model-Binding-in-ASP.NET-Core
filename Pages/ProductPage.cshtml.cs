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
        public void OnGet(int? id)
        {
            if ( id != null){
                ViewData["Title"] = $"Sản phẩm (ID = {id.Value})";
            }else{
                ViewData["Title"] = $"Danh sach san pham";
            }
            
        }
    }
}
