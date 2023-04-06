using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pagemodelexample.Pages
{
    public class ProductPageModel : PageModel
    {
        private readonly ILogger<ProductPageModel> _logger;

        public readonly ProductService productService;
        public ProductPageModel(ILogger<ProductPageModel> logger, ProductService _productServices){
            _logger = logger;
            productService = _productServices;
        }

        //OnGet, OnPos, OnGetAbc... Http Request
        //void IActionResult

        public Product product {set;get;}
        public void OnGet(int? id)
        {
            if ( id != null){
                ViewData["Title"] = $"Sản phẩm (ID = {id.Value})";
                product = productService.Find(id.Value);
            }else{
                ViewData["Title"] = $"Danh sach san pham";
            }
            
        }

        // /product/{id:int?}?handle=lastproduct
        public IActionResult OnGetLastProduct(){
            ViewData["Title"] = $"San pham cuoi";
            product = productService.AllProducts().LastOrDefault();
            if(product != null){
                return Page();
            }else{
                return this.Content("Khong thay san pham");
            }
        }

        public IActionResult OnGetRemoveAll(){
            productService.AllProducts().Clear();

            return RedirectToPage("ProductPage");
        }

        public IActionResult OnGetLoad(){
            productService.LoadProducts();
            return RedirectToPage("ProductPage");
        }
    }
}
