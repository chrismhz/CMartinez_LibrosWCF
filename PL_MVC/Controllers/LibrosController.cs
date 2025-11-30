using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class LibrosController : Controller
    {
        // GET: Libros
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Libro libro = new ML.Libro();
            ML.Result result = BL.Libro.GetAllEF();

            if (result.Correct)
            {
                libro.Libros = result.Objects;
            }
            else
            {
                ViewBag.MessageError = "No se pudo mostrar la informacion" + result.ErrorMessage;
            }
            
            return View(libro);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Libro libro)
        {
            ML.Result result = BL.Libro.GetAllEF();

            if (result.Correct)
            {
                libro.Libros = result.Objects;
            }
            else
            {
                ViewBag.MessageError = "No se pudo mostrar la informacion" + result.ErrorMessage;
            }

            return View(libro);
        }

        [HttpGet]
        public ActionResult Form(int? IdLibro) 
        {
            ML.Libro libro = new ML.Libro();
            

            if(IdLibro != null) //Update con GetById
            {
                ML.Result result = BL.Libro.GetByIdEF(IdLibro.Value);

                if (result.Correct)
                {
                    libro = (ML.Libro)result.Object;
                    result.Correct = true;
                }
                else
                {
                    ViewBag.MessageError = "Ocurrio un error al traer la informacion";
                }
            }

            return View(libro);
        }

        [HttpPost]
        public ActionResult Form(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            if(libro.IdLibro == 0)
            {
                result = BL.Libro.AddEF(libro);

                if (result.Correct)
                {
                    ViewBag.Message = "El registro se ha competado con exito";
                }
                else
                {
                    ViewBag.Message = "Fallo al registrar en el sistema";
                }
            }
            else
            {
                if(libro.IdLibro > 0)
                {
                    result = BL.Libro.UpdateEF(libro);

                    if (result.Correct)
                    {
                        ViewBag.Message = "El registro se ha actualizado con exito";
                    }
                    else
                    {
                        ViewBag.Message = "Fallo al actualizar en el sistema";
                    }
                }
            }

            return PartialView("Modal");
        }

        [HttpGet]
        public ActionResult Delete(int IdLibro)
        {
            if (IdLibro > 0)
            {
                ML.Result result = BL.Libro.DeleteEF(IdLibro);

                if (result.Correct)
                {
                    ViewBag.Message = "Se elimino correctamente el registro";
                }
                else
                {
                    ViewBag.Message = "Hubo un error al eliminar el registro";
                }
            }

            return PartialView("Modal");
        }

    }
}