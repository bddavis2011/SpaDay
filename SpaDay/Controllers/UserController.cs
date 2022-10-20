using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }
        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User(addUserViewModel.Username, addUserViewModel.Email, addUserViewModel.Password);
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    return View("Index", user);
            } else
            {
                ViewBag.error = "Passwords do not match! Try again!";
                return View("Add", user);
            }
        }
            ViewBag.Error = "One or more inputs are not valid";
            return View("Add");
       
    }
}
