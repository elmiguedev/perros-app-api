using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using perros_app_api.Modelo;

namespace perros_app_api.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    public class PerroController : Controller
    {
        // instancia contexto
        private readonly PerrosContext _context;

        public PerroController(PerrosContext context)
        {
            _context = context;

            // if (_context.Perros.Count() == 0)
            // {
            //     _context.Perros.Add(new Perro { Id=1, Nombre= "Pichicho", Raza="Chihuahua"  });
            //     _context.SaveChanges();
            // }
        }


        // GET api/Perro
        [HttpGet]
        public IEnumerable<Perro> Get()
        {
            return this._context.Perros.ToList();
        }

        // GET api/Perro/5
        [HttpGet("{id}")]
        public Perro Get(int id)
        {
            return this._context.Perros.Find(id);
        }

        // POST api/Perro
        [HttpPost]
        public void Post([FromBody]Perro value)
        {
            this._context.Perros.Add(value);
            this._context.SaveChanges();
        }

        // PUT api/Perro/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Perro value)
        {
            var perro = this._context.Perros.Find(id);
            perro.Nombre = value.Nombre;
            perro.Raza = value.Raza;
            this._context.SaveChanges();
        }

        // DELETE api/Perro/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._context.Perros.Remove(this._context.Perros.Find(id));
            this._context.SaveChanges();
        }
    }
}
