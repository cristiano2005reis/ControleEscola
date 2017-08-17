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

            //try
            //{
            //    using (ProfessorService service = new ProfessorService())
            //    {
            //        service.BuscaProfessor(12);
            //    }
            //}

            //catch(Exception e)
            //{
            //    return e.Message;
            //}

            return View(prof);
        }

        public HttpResponse Index(long id)
        {
            return null;
        }
    }
}