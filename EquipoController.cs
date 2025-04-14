using Ligapro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ligapro.Controllers
{

    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            List<Equipos> equipos = new List<Equipos>();
            Equipos ldu = new Equipos
            {
                ID = 1,
                nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };
            equipos.Add(ldu);

             Equipos bsc = new Equipos
            {
                ID = 2,
                nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 1,
                PartidosPerdidos = 8
            };
            equipos.Add(bsc);

            return View(equipos);
             
        }
    }
}

