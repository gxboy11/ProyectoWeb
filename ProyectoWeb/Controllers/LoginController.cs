using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;
namespace ProyectoWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly ProyectoWebContext _context = new ProyectoWebContext();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario model)
        {   
            if (UsuarioAutenticado(model))
            {   
                return RedirectToAction("Index", "Home");
            }
            else
            { 
                ModelState.AddModelError(string.Empty, "Inicio de sesión incorrecto. Por favor, inténtalo de nuevo.");
                return View(model);   
            }
        }
        private bool UsuarioAutenticado(Usuario usuario)
        {
            var todosLosUsuarios = _context.Usuarios.ToList();

            var usuarioEncontrado = todosLosUsuarios.FirstOrDefault(u => u.Nombre == usuario.Nombre);

            if (usuarioEncontrado != null)
            {
                if (usuario.Nombre == usuarioEncontrado.Nombre && usuario.Contrasena == usuarioEncontrado.Contrasena)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
