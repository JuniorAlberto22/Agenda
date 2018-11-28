using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class Atividade : DbContext
    {
        public Atividade() : base("name=Model1")
        {
        }

        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public List<Pessoa> pessoas { get; set; }
    }
}