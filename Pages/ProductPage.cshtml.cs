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
        // Nếu chỉ muốn đọc từng cái thì sử dụng từng thuộc tính sau:
        //Đọc từ Query thì dùng:
        // [FromQuery]
        // //doc tu Route thi dung
        // [FromRoute]

        // [FromForm]
        // [FromHeader]
        // [FromBody]


        public void OnGet(int? id, [Bind("Id","Name")]Product sanpham)
        {
            Console.WriteLine($"ID: {sanpham.Id}");
            Console.WriteLine($"ID: {sanpham.Name}");
            // var data = this.Request.Form["id"];
            // var data = this.Request.Query["id"];
            // var data = this.Request.RouteValues["id"];
            // var data = this.Request.Headers["id"];

            // var data = this.Request.Query["id"];
            // if(!string.IsNullOrEmpty(data)){
            //     Console.WriteLine(data.ToString());
            //     int.Parse(data.ToString());
            // }


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

        public IActionResult OnPostDelete(int? id){
            if(id != null){
                product = productService.Find(id.Value);
                if(product != null){
                    productService.AllProducts().Remove(product);
                }
            }

            return this.RedirectToPage("ProductPage", new{id = string.Empty});
        }
    }
}
