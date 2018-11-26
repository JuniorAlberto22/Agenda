using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class Telefone
    {
        public long Id { get; set; }
        public string Tel { get; set; }
        public TipoTelefone Tipo { get; set; }
    }
}