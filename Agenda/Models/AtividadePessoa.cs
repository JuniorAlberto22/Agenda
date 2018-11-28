using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Agenda.Models
{
    public class AtividadePessoa : DbContext
    {
        public AtividadePessoa() : base("name=Model1")
        {
        }

        public long Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public Atividade Atividade { get; set; }
    }
}