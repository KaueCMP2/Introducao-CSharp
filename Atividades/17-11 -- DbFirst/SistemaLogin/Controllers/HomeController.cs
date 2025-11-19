using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using SistemaLogin.Models;

namespace SistemaLogin.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("UsuarioNome") == null)
        {
            return RedirectToAction("Index" , "Login");
        }

        // Nesse caso a view bag carrega as informacoes para a view 
        ViewBag.Usuario = HttpContext.Session.GetString("UsuarioNome");
        return View();
    }
}
