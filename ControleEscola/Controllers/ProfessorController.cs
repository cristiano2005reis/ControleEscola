using Business.Models;
using Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEscola.Controllers
{
    public class ProfessorController:Controller
    {
        public ActionResult Index()
        {
            Professor prof = new Professor();

            prof.Nome = "Raphael Macedo";
            prof.IdProfessor = 1;
                      
            return View(prof);
        }

        public ActionResult BuscarProfessor()
        {
            ProfessorService service = new ProfessorService();
            Professor model = new Professor();
            model = service.BuscaProfessor();

            return View(model);
        }

        public ActionResult InserirProfessor()
        {
            return View();
        }

    }
}