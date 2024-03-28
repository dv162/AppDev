using AppDev.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Book
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    [ValidateNever]
    public int CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    [ValidateNever]
    public Category Category { get; set; }
    [ValidateNever]
    public string? ImageUrl { get; set; }

}