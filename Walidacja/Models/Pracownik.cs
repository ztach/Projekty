using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Walidacja.Models
{
    public class Pracownik
    {
        [ScaffoldColumn(false)]
        public int PracownikId { get; set; }

        [Display(Name = "Imię Pracownika:")]
        [Required(ErrorMessage ="Musisz wprowadzić imię")]
        [StringLength(30)]
        public string Imie { get; set; }

        [Display(Name = "Wiek Pracownika:")]
        [Required(ErrorMessage = "Musisz wprowadzić wiek")]
        [Range(10,20)]
        public int Wiek { get; set; }

        [Display(Name = "Email Pracownika:")]
        [Required(ErrorMessage = "Musisz wprowadzić maila")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Range(10,10, ErrorMessage ="telefon ma 10 cyfr")]
        [RegularExpression(@"[0-9]*")]
        public string NumerTelefonu { get; set; }

        [Display(Name = "Pytanie do szefa:")]
        [DataType(DataType.MultilineText)]
        public string Pytanie { get; set; }


    }
}