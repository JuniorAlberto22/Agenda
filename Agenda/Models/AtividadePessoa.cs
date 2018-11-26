using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class AtividadePessoa
    {
        public long Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public Atividade Atividade { get; set; }
    }
}