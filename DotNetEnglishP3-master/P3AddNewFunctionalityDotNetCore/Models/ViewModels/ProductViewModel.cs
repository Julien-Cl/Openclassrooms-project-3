using Microsoft.AspNetCore.Mvc.ModelBinding;

using System.ComponentModel.DataAnnotations; // Ajout pour pouvoir utiliser l'attribut "Required"


namespace P3AddNewFunctionalityDotNetCore.Models.ViewModels
{
    public class ProductViewModel
    {
        [BindNever]
        public int Id { get; set; }


        [Required(ErrorMessage = "Veuillez saisir le nom du produit")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Veuillez saisir la description du produit")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Veuillez saisir les détails du produit")]
        public string Details { get; set; }

        // Ajout d'un regex pour ne tolérer qu'un entier
        [RegularExpression("[0-9]+$", ErrorMessage = "Le stock doit être un entier positif")]
        [Required(ErrorMessage = "Veuillez saisir le stock du produit")]
        public string Stock { get; set; }

        // Ajout d'un regex pour tolérer un entier ou un nombre
        [RegularExpression("^[0-9]+(\\.[0-9]+)?$", ErrorMessage = "Le prix doit être un nombre positif")]
        [Required(ErrorMessage = "Veuillez saisir le prix du produit")]
        public string Price { get; set; }
    }
}
