
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactRequestModel : PageModel{
    [BindProperty(SupportsGet = true)]
    public string UserId {get;set;}
    [BindProperty]
    public string Email {get;set;}
    [BindProperty(SupportsGet = true)]
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