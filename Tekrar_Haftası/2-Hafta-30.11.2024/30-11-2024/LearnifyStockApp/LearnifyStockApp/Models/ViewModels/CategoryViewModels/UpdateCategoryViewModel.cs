using System;
using System.ComponentModel.DataAnnotations;

namespace LearnifyStockApp.Models.ViewModels.CategoryViewModels;

public class UpdateCategoryViewModel
{
    public int Id { get; set; }

    [Display(Name = "Kategori Adı")]
    [Required(ErrorMessage = "Bu alanı boş bırakmayınız.")]
    [MinLength(3, ErrorMessage = "Bu alan en az 3 karater uzunluğunda olmalıdır.")]
    public string? Name { get; set; }

    [Display(Name = "Kategori Adı")]
    [Required(ErrorMessage = "Bu alanı boş bırakmayınız.")]
    [MinLength(3, ErrorMessage = "Bu alan en az 3 karater uzunluğunda olmalıdır.")]
    public string? Description { get; set; }

    [Display(Name = "Son Güncellenme Tarihi:")]
    public DateTime UpdatedAt { get; set; }

}
