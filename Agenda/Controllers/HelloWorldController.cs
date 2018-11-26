using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenda.Models;

namespace Agenda.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa()
                { Nome="Alberto", Email="email@gmail.com",
                    Telefones=new List<Telefone>(){
                        new Telefone() { Tel="(99) 9999-9999" },
                        new Telefone() { Tel="(99) 9999-9999" }
                    }
                },
                new Pessoa()
                { Nome="Alberto", Email="email@gmail.com",
                    Telefones=new List<Telefone>(){
                        new Telefone() { Tel="(99) 9999-9999" },
                        new Telefone() { Tel="(99) 9999-9999" }
                    }
                },
                new Pessoa()
                { Nome="Alberto", Email="email@gmail.com",
                    Telefones=new List<Telefone>(){
                        new Telefone() { Tel="(99) 9999-9999" },
                        new Telefone() { Tel="(99) 9999-9999" }
                    }
                },
                new Pessoa()
                { Nome="Alberto", Email="email@gmail.com",
                    Telefones=new List<Telefone>(){
                        new Telefone() { Tel="(99) 9999-9999" },
                        new Telefone() { Tel="(99) 9999-9999" }
                    }
                },
                new Pessoa()
                { Nome="Alberto", Email="email@gmail.com",
                    Telefones=new List<Telefone>(){
                        new Telefone() { Tel="(99) 9999-9999" },
                        new Telefone() { Tel="(99) 9999-9999" }
                    }
                },
                new Pessoa()
                { Nome="Alberto", Email="email@gmail.com",
                    Telefones=new List<Telefone>(){
                        new Telefone() { Tel="(99) 9999-9999" },
                        new Telefone() { Tel="(99) 9999-9999" }
                    }
                }
            };
            return View(pessoas);
        }
    }
}