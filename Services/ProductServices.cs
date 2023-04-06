using System.Linq;
public class ProductService
{
    private List<Product> products = new List<Product>();

    public ProductService(){
        LoadProducts();
    }
    public Product Find(int id){
        var qr = from p in products
                where p.Id == id select p;
        return qr.FirstOrDefault();
    }
    public List<Product> AllProducts() => products;
    public void LoadProducts(){
        products.Clear();
        products.Add(new Product(){
            Id = 1,
            Name = "Iphone",
            Price = 900,
            Description = "Dien thoai Iphone acb, xyz...."
        });
        products.Add(new Product(){
            Id = 2,
            Name = "Samsung",
            Price = 700,
            Description = "Dien thoai Samsung acb, xyz...."
        });
        products.Add(new Product(){
            Id = 3,
            Name = "Nokia",
            Price = 800,
            Description = "Dien thoai Nokia...."
        });
    }
}