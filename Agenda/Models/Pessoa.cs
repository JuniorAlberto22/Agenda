using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Agenda.Models
{
    public class Pessoa : DbContext
    {
        public Pessoa() : base("name=Model1")
        {

        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}