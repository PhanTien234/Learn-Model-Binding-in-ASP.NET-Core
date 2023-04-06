
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactRequestModel : PageModel{
    [BindProperty]
    [DisplayName("Id cua ban")]
    [Range(10,100, ErrorMessage = "Nhap sai")]
    public int UserId {get;set;}
    [BindProperty]
    [DisplayName("Email cua ban")]
    [EmailAddress(ErrorMessage ="Email sai dinh dang")]
    public string Email {get;set;}
    [BindProperty]
    [DisplayName("Ten nguoi dung")]
    public string UserName {get; set;}

    private readonly ILogger<ContactRequestModel> _logger;
    public ContactRequestModel(ILogger<ContactRequestModel> logger){
        _logger = logger;
        _logger.LogInformation("Init contact ...");
        Console.WriteLine("Init contact...");
    }

    public double Tong(double a, double b){
        return a + b;
    }
}