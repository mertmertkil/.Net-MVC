using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="Email is required.")]
        public string? Email { get; set; } = string.Empty;
        [Required(ErrorMessage ="Firstname is required.")]

        public string? FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage ="Lastname is required.")]

        public string? LastName { get; set; } = string.Empty;

        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int Age { get; set; }
        [Required(ErrorMessage ="Course is required.")]

        public string? SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }

        // Kurucu metot (constructor)
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}
