using System;
using System.ComponentModel.DataAnnotations;

namespace LearnifyStockApp.Models.ViewModels.CategoryViewModels;

public class AddCategoryViewModel
{
    [Display(Name ="Kategori Adı")]
    [Required(ErrorMessage ="Bu alanı boş bırakmayınız.")]
    [MinLength(3,ErrorMessage ="Bu alan en az 3 karater uzunluğunda olmalıdır.")]
    public string? Name { get; set; }
    [Display(Name = "Kategori Açıklaması")]
    [Required(ErrorMessage = "Bu alanı boş bırakmayınız.")]
    [MinLength(10, ErrorMessage = "Bu alan en az 10 karater uzunluğunda olmalıdır.")]
    public string? Description { get; set; }
}
