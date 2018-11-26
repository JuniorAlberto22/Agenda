using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agenda.DTOs;

namespace Agenda.DTOs
{
    public class TelefoneDTO
    {
        public long Id { get; set; }
        public string Tel { get; set; }
        public TipoTelefoneDTO Tipo { get; set; }
    }
}