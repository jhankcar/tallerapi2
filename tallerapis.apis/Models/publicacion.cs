using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tallerapis.apis.Models
{
    public class publicacion : DbContext
    {
        public publicacion() : base("PublicacionConnection")
        {

        }

        public DbSet<tblpublicacion> Publicacion { get; set; }
    }
}

