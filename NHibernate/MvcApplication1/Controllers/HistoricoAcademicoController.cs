using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using Core.Domain.Model;
using Core.Domain.Repositories;

namespace MvcApplication1.Controllers
{
    public class HistoricoAcademicoController : Controller
    {
        public ActionResult Index(int id)
        {
            var resultados = Factory.GetAll("Core.Domain.Model.HistoricoAcademico", "Pessoa.IdPessoa", new decimal(id));
            IList<HistoricoAcademicoModel> listaModel = new List<HistoricoAcademicoModel>();
            foreach(HistoricoAcademico resultado in resultados) 
            {
                HistoricoAcademicoModel model = new HistoricoAcademicoModel();
                model.Curso = resultado.Curso;
                model.DataFim = resultado.DataFim;
                model.DataInicio = resultado.DataInicio;
                model.Nota = resultado.Nota;
                model.Presenca = resultado.Presenca;
                model.Instituicao = resultado.Instituicao;
                model.IdPessoa = decimal.ToInt32(resultado.Pessoa.IdPessoa);
                model.IdHistoricoAcademico = decimal.ToInt32(resultado.IdHistoricoAcademico);

                listaModel.Add(model);
            }

            return View(listaModel);
        }

        //
        // GET: /HistoricoAcademico/Create/5

        public ActionResult Create(int id)
        {
            return View(new HistoricoAcademicoModel { IdPessoa = id, DataInicio = null, DataFim = null, Nota = null, Presenca = null });
        }

        //
        // GET: /HistoricoAcademico/Create/
        [HttpPost]
        public ActionResult Create(HistoricoAcademicoModel model)
        {
            if (ModelState.IsValid)
            {
                HistoricoAcademico historicoAcademico = new HistoricoAcademico();                
                historicoAcademico.Curso = model.Curso;
                historicoAcademico.DataFim = model.DataFim;
                historicoAcademico.DataInicio = model.DataInicio;
                historicoAcademico.Instituicao = model.Instituicao;
                historicoAcademico.Nota = (float) model.Nota;
                historicoAcademico.Presenca = (float) model.Presenca;
                historicoAcademico.Pessoa = new Pessoa { IdPessoa = model.IdPessoa };

                Factory.Save(historicoAcademico);

                return RedirectToAction("Index", "HistoricoAcademico", new { id = model.IdPessoa });
            }

            return View();
        }

        //
        // GET: /HistoricoAcademico/Details/5

        public ActionResult Details(int id)
        {
            HistoricoAcademico historicoAcademico = (HistoricoAcademico)Factory.GetById("Core.Domain.Model.HistoricoAcademico", new decimal(id));
            HistoricoAcademicoModel model = new HistoricoAcademicoModel();
            model.Curso = historicoAcademico.Curso;
            model.DataFim = historicoAcademico.DataFim;
            model.DataInicio = historicoAcademico.DataInicio;
            model.Instituicao = historicoAcademico.Instituicao;
            model.Nota = historicoAcademico.Nota;
            model.Presenca = historicoAcademico.Presenca;
            model.IdHistoricoAcademico = decimal.ToInt32(historicoAcademico.IdHistoricoAcademico);
            model.IdPessoa = decimal.ToInt32(historicoAcademico.Pessoa.IdPessoa);

            return View(model);
        }     
        
        //
        // GET: /HistoricoAcademico/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HistoricoAcademico/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, HistoricoAcademicoModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HistoricoAcademico historicoAcademico = new HistoricoAcademico();
                    historicoAcademico.Curso = model.Curso;
                    historicoAcademico.DataFim = model.DataFim;
                    historicoAcademico.DataInicio = model.DataInicio;
                    historicoAcademico.Instituicao = model.Instituicao;
                    historicoAcademico.Nota = (float)model.Nota;
                    historicoAcademico.Presenca = (float)model.Presenca;
                    historicoAcademico.Pessoa = new Pessoa { IdPessoa = model.IdPessoa };

                    Factory.Update(historicoAcademico);

                    return RedirectToAction("Index", "HistoricoAcademico", new { id = model.IdPessoa });
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        //
        // GET: /HistoricoAcademico/Delete/5
 
        public ActionResult Delete(int id)
        {
            HistoricoAcademico historicoAcademico = (HistoricoAcademico)Factory.GetById("Core.Domain.Model.HistoricoAcademico", new decimal(id));
            HistoricoAcademicoModel model = new HistoricoAcademicoModel();
            model.Curso = historicoAcademico.Curso;
            model.DataFim = historicoAcademico.DataFim;
            model.DataInicio = historicoAcademico.DataInicio;
            model.Instituicao = historicoAcademico.Instituicao;
            model.Nota = historicoAcademico.Nota;
            model.Presenca = historicoAcademico.Presenca;
            model.IdHistoricoAcademico = decimal.ToInt32(historicoAcademico.IdHistoricoAcademico);
            model.IdPessoa = decimal.ToInt32(historicoAcademico.Pessoa.IdPessoa);

            return View(model);
        }

        //
        // POST: /HistoricoAcademico/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                HistoricoAcademico historicoAcademico = (HistoricoAcademico)Factory.GetById("Core.Domain.Model.HistoricoAcademico", new decimal(id));
                Factory.Delete(historicoAcademico);

                return RedirectToAction("Index", "HistoricoAcademico", new { id = historicoAcademico.Pessoa.IdPessoa }); 
            }
            catch
            {
                return View();
            }
        }
    }
}
