using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Agenda.Models
{
    public class Telefone : DbContext
    {
        public Telefone() : base("name=Model1")
        {

        }

        public long Id { get; set; }
        public string Tel { get; set; }
        public TipoTelefone Tipo { get; set; }
    }
}