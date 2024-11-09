using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project08_ProtfolioApp.Areas.Admin.Models;

public class AddProjectViewModel
{

    [Required(ErrorMessage = "Proje Adı Boş Bırakılamaz.!")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Açıklama Boş Bırakılamaz.!")]
    [MinLength(5, ErrorMessage = "En az 5 karakter uzunluğunda olmalıdır.!")]
    public string? Description { get; set; }
    public string? GithubUrl { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; }
    public DateTime ModifiedDate { get; set; }
    public int CategoryId { get; set; }
    public List<SelectListItem>? CategoryList { get; set; }

    public IFormFile? Image { get; set; }



}
