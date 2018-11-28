using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Agenda.Models
{
    public class TipoTelefone : DbContext
    {
        public TipoTelefone() : base("name=Model1")
        {
            
        }

        public long Id { get; set; }
        public string Descricao { get; set; }
    }
}