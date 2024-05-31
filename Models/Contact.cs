using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MultiPageWebAppWithDB.Models;

public class Contact
{
    public int ContactId { get; set; }

    [Required(ErrorMessage = "Please enter a name.")]
    [RegularExpression(@"^[a-zA-Z'""\-_\s]+$", ErrorMessage = "The name can only contain letters, apostrophes, hyphens")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter a phone number")]
    [RegularExpression(@"^\d{3}\-\d{3}-\d{4}$", ErrorMessage = "The phone number must be in the format 123-456-7890.")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Please enter a address")]
    [RegularExpression(@"^[a-zA-Z0-9\s,'\-\.]+$", ErrorMessage = "The address can only contain letters, numbers, spaces, commas, apostrophes, hyphens, and periods.")]
    public string Address { get; set; }


    [Required(ErrorMessage = "Please enter a note")]
    // I dont think this needs validation? the user shouldn't be restricted in a note. 
    public string Note { get; set; }

    public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + PhoneNumber?.ToString();
}
