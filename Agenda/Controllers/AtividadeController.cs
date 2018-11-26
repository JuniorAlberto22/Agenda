using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenda.Models;

namespace Agenda.Controllers
{
    public class AtividadeController : Controller
    {
        // GET: Atividade
        public ActionResult Index()
        {
            IEnumerable<Atividade> atividades = new List<Atividade>()
            {
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()},
                new Atividade(){ Titulo="Titulo1", Descricao="Uma descrição qualquer2", DataHora = new DateTime()}
            };
            return View(atividades);
        }
    }
}