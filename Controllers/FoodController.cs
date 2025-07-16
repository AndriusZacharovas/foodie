using Microsoft.AspNetCore.Mvc;
using FoodOrderApp.Models;

namespace FoodOrderApp.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            var foodList = new List<Food>
            {
                new Food { Id = 1, Name = "Burger", Price = 4.99m, ImageUrl = "/images/image.jpeg" },
                new Food { Id = 2, Name = "Pizza", Price = 7.99m, ImageUrl = "/images/image.jpeg" },
                new Food { Id = 3, Name = "Pasta", Price = 6.49m, ImageUrl = "/images/image.jpeg" },
            };

            return View(foodList);
        }
    }
}
