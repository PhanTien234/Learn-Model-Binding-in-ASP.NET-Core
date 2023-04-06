
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Contact : PageModel{
    public string UsedId {get;set;} = "XuanThuLAb";

    public Contact(){
        Console.WriteLine("Init contact...");
    }

    public double Tong(double a, double b){
        return a + b;
    }
}