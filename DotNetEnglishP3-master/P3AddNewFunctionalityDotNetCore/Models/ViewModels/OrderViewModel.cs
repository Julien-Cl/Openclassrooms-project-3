using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace P3AddNewFunctionalityDotNetCore.Models.ViewModels
{
    public class OrderViewModel
    {
        [BindNever]
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        //[Required(ErrorMessage = "Veuillez ajouter votre nom")]
        [Required(
        ErrorMessageResourceName = "ErrorMissingName", // On pointe le bon nom d'erreur
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order) // On pointe la classe définissant cette erreur
        )]
        //[RegularExpression("^[^0-9]+$", ErrorMessage = "Le nom ne doit pas contenir de chiffre.")]
        [RegularExpression(
        "^[^0-9]+$",
        ErrorMessageResourceName = "ErrorInvalidName", // On pointe vers le bon nom d'erreur
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order) // On pointe la classe définissant cette erreur
        )]
        public string Name { get; set; }



        //[Required(ErrorMessage = "Veuillez ajouter votre adresse")]
        [Required(
        ErrorMessageResourceName = "ErrorMissingAddress",
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order)
        )]
        public string Address { get; set; }



        //[Required(ErrorMessage = "Veuillez ajouter votre ville")]
        [Required(
        ErrorMessageResourceName = "ErrorMissingCity",
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order)
        )]
        //[RegularExpression("^[^0-9]+$", ErrorMessage = "La ville ne doit pas contenir de chiffre.")]
        [RegularExpression(
        "^[^0-9]+$",
        ErrorMessageResourceName = "ErrorInvalidCity",
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order)
        )]
        public string City { get; set; }



        //[Required(ErrorMessage = "Veuillez ajouter votre code postal")]
        [Required(
        ErrorMessageResourceName = "ErrorMissingZipCode",
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order)
        )]
        //[RegularExpression("^[0-9]+$", ErrorMessage = "Le code postal doit contenir uniquement des chiffres.")]
        [RegularExpression(
        "^[0-9]+$",
        ErrorMessageResourceName = "ErrorInvalidZipCode",
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order)
        )]
        public string Zip { get; set; }



        //[Required(ErrorMessage = "Veuillez ajouter votre pays")]
        [Required(
        ErrorMessageResourceName = "ErrorMissingCountry",
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order)
        )]
        //[RegularExpression("^[^0-9]+$", ErrorMessage = "Le pays ne doit pas contenir de chiffre.")]
        [RegularExpression(
        "^[^0-9]+$",
        ErrorMessageResourceName = "ErrorInvalidCountry",
        ErrorMessageResourceType = typeof(P3.Resources.Models.Order)
        )]
        public string Country { get; set; }



        [BindNever]
        public DateTime Date { get; set; }
    }
}
