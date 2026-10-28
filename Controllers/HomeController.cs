using Microsoft.AspNetCore.Mvc;
using PrayerasJyC.Models;

namespace PrayerasJyC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ofertas = new List<Producto>
            {
                new Producto { Nombre = "Combo Duo Parejas (2 Playeras)", Categoria = "Promoción 20% OFF", Precio = "$350.00", Imagen = "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?q=80&w=600" },
                new Producto { Nombre = "Pack Familiar (4 Playeras)", Categoria = "Oferta Especial", Precio = "$650.00", Imagen = "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?q=80&w=600" },
                new Producto { Nombre = "Playera Oversize Urbana", Categoria = "Descuento del Mes", Precio = "$190.00", Imagen = "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?q=80&w=600" }
            };

            return View(ofertas);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(string nombre, string email, string playera, string talla, string detalles)
        {
            ViewBag.Mensaje = $"¡Gracias {nombre}! Hemos recibido tu solicitud para la '{playera}' (Talla: {talla}). Nos pondremos en contacto contigo a {email} a la brevedad.";
            return View();
        }

        public IActionResult Faq()
        {
            return View();
        }
    }
}