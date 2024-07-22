using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TaskManagerProject.Models;
public class AccountController : Controller
{
    // Display the login page
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    // Handle the login form submission
    [HttpPost]
    public async Task<IActionResult> Login(LoginModel model)
    {
        if (ModelState.IsValid)
        {
            var user = ValidateUser(model.Username, model.Password);
            if (user != null)
            {
                var claims = new List<Claim>
               {
                   new Claim(ClaimTypes.Name, model.Username),
                   
               };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                   
                };
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        }
        return View(model);
    }
    // Handle user logout
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Login", "Account");
    }
    private LoginModel ValidateUser(string username, string password)
    {
        // This is a placeholder for actual user validation logic (e.g., querying a database)
        // Example:
        if (username == "admin" && password == "password")
        {
            return new LoginModel { Username = "admin", Role = "Admin" };
        }
        else if (username == "manager" && password == "password")
        {
            return new LoginModel { Username = "manager", Role = "Manager" };
        }
        else if (username == "employee" && password == "password")
        {
            return new LoginModel { Username = "employee", Role = "Employee" };
        }
        return null;
    }
}