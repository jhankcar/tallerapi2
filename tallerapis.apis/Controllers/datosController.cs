using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tallerapis.apis.Models;

namespace tallerapis.apis.Controllers
{
    public class datosController : ApiController
    {
        [HttpGet]
        public IEnumerable<tblpublicacion> Get()
        {
            using (var context = new publicacion())
            {
                return context.Publicacion.ToList();
            }
        }

        [HttpGet]
        public tblpublicacion Get(int id)
        {
            using (var context = new publicacion())
            {
                return context.Publicacion.FirstOrDefault(x => x.Id == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(tblpublicacion producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new publicacion())
            {
                context.Publicacion.Add(producto);
                context.SaveChanges();
                return Ok(producto);
            }
        }

        [HttpPut]
        public tblpublicacion Put(tblpublicacion publicaciones)
        {
            using (var context = new publicacion())
            {
                var publicacionAct = context.Publicacion.FirstOrDefault(x => x.Id == publicaciones.Id);
                publicacionAct.Usuario = publicaciones.Usuario;
                publicacionAct.Descripcion = publicaciones.Descripcion;
                publicacionAct.FechaPublicacion = publicaciones.FechaPublicacion;
                publicacionAct.MeGusta = publicaciones.MeGusta;
                publicacionAct.MeDisgusta = publicaciones.MeDisgusta;
                publicacionAct.VecesCompartido = publicaciones.VecesCompartido;
                publicacionAct.EsPrivada = publicaciones.EsPrivada;
                context.SaveChanges();
                return publicaciones;
            }
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            using (var context = new publicacion())
            {
                var productoDel = context.Publicacion.FirstOrDefault(x => x.Id == Id);
                context.Publicacion.Remove(productoDel);
                context.SaveChanges();
                return true;
            }
        }
    }
}
