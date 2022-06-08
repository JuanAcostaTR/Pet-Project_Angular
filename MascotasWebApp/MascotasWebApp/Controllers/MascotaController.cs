using MascotasWebApp.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace MascotasWebApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET, POST, PUT, DELETE, OPTIONS")]
    public class MascotaController : ApiController
    {
        public IEnumerable<Mascota> Get()
        {
            GestorMascota gMascota = new GestorMascota();
            return gMascota.getMascota();
        }

        // GET: api/Mascota/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mascota
        public bool Post([FromBody] Mascota mascota)
        {
            GestorMascota gMascota = new GestorMascota();
            bool res = gMascota.addMascota(mascota);

            return res;
        }

        // PUT: api/Mascota/5
        public bool Put(int id, [FromBody] Mascota mascota)
        {
            GestorMascota gMascota = new GestorMascota();
            bool res = gMascota.updateMascota(id, mascota);

            return res;
        }

        // DELETE: api/Mascota/5
        public bool Delete(int id)
        {
            GestorMascota gMascota = new GestorMascota();
            bool res = gMascota.deleteMascota(id);

            return res;
        }
    }
}