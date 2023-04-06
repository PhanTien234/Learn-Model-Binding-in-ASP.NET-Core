using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

public class UserContact{
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
}