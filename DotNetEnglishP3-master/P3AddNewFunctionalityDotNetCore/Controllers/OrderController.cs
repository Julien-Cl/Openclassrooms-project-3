using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using P3AddNewFunctionalityDotNetCore.Models;
using P3AddNewFunctionalityDotNetCore.Models.Services;
using P3AddNewFunctionalityDotNetCore.Models.ViewModels;

namespace P3AddNewFunctionalityDotNetCore.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICart _cart;
        private readonly IOrderService _orderService;
        private readonly IStringLocalizer<OrderController> _localizer;

        public OrderController(ICart cart, IOrderService service, IStringLocalizer<OrderController> localizer)
        {
            _cart = cart;
            _orderService = service;
            _localizer = localizer;
        }

        public ViewResult Index()
        {
            return View(new OrderViewModel());
        }

        [HttpPost]
        public IActionResult Index(OrderViewModel order)
        {
            // Si le panier est vide, ajout d'un message d'erreur manuel
            if (!((Cart) _cart).Lines.Any())
            {
                ModelState.AddModelError("", _localizer["CartEmpty"]);
            }



            // Si le modelState est valide: on valide et on renvoie vers la page "Completed"
            if (ModelState.IsValid)
            {
                order.Lines = ((Cart) _cart)?.Lines.ToArray();
                _orderService.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }

            // Si le modelState est invalide: envoi des erreurs avec ajout des erreurs automatiques (complétion des champs)
            else
            {
                return View(order);
            }
        }

        public ViewResult Completed()
        {
            _cart.Clear();
            return View();
        }
    }
}
