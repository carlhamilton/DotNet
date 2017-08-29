using Microsoft.AspNetCore.Mvc;
using OdeToFood.Entities;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;
using System.Linq;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            var model = new HomePAgeViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetGreeting();

            ///  return new ObjectResult(model);


            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //use during post to check for forgery
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {

                var newRestaurant = new Restaurant();
                newRestaurant.Cuisine = model.Cuisine;
                newRestaurant.Name = model.Name;

                newRestaurant = _restaurantData.Add(newRestaurant);

                return RedirectToAction("Details", new { id = newRestaurant.Id });
            }

            return View();

        }
    }


}
