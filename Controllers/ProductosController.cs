using Microsoft.AspNetCore.Mvc;
using PrayerasJyC.Models;

namespace PrayerasJyC.Controllers
{
    public class ProductosController : Controller
    {
        private static List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Playera Anime Custom", Categoria = "Estampados", Precio = "$190.00", Imagen = "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?q=80&w=600" },
            new Producto { Nombre = "Playera Tipografía Minimal", Categoria = "Diseño Propio", Precio = "$180.00", Imagen = "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?q=80&w=600" },
            new Producto { Nombre = "Playera Gamer Neon", Categoria = "Estampados", Precio = "$210.00", Imagen = "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?q=80&w=600" },
            new Producto { Nombre = "Playera Oversize Urbana", Categoria = "Básicas", Precio = "$220.00", Imagen = "https://images.unsplash.com/photo-1618354691373-d851c5c3a990?q=80&w=600" },
            new Producto { Nombre = "Playera Retro Synthwave", Categoria = "Diseño Propio", Precio = "$200.00", Imagen = "https://images.unsplash.com/photo-1576566588028-4147f3842f27?q=80&w=600" },
            new Producto { Nombre = "Playera Tie-Dye Cyber", Categoria = "Especiales", Precio = "$250.00", Imagen = "https://images.unsplash.com/photo-1503341455253-b2e723bb3dbb?q=80&w=600" }
        };

        public IActionResult Index()
        {
            return View(productos);
        }

        public IActionResult Detalle(string nombre)
        {
            var p = productos.FirstOrDefault(x => x.Nombre == nombre) ?? productos[0];
            return View(p);
        }
    }
}