using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CRUDLEntities context = new DL_EF.CRUDLEntities())
                {
                    var listaLibros = context.LibrosGetAll().ToList();

                    if (listaLibros.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var libro in listaLibros)
                        {
                            ML.Libro libroItem = new ML.Libro();
                            libroItem.IdLibro = libro.IdLibro;
                            libroItem.Titulo = libro.Titulo;
                            libroItem.Editorial = libro.Editorial;
                            libroItem.FechaPublicacion = libro.FechaPublicacion.Value.ToString("dd/MM/yyyy");
                            libroItem.Genero = libro.Genero;
                            libroItem.NumPaginas = Convert.ToInt32(libro.NumPaginas);
                            libroItem.Precio = Convert.ToDecimal(libro.Precio);
                            libroItem.Stock = Convert.ToInt32(libro.Stock);

                            result.Objects.Add(libroItem);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Hubo un error en traer la informacion";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result GetByIdEF(int IdLibro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CRUDLEntities context = new DL_EF.CRUDLEntities())
                {
                    var libro = context.LibrosGetById(IdLibro).SingleOrDefault();

                    if (libro != null)
                    {
                        ML.Libro libroItem = new ML.Libro();

                        libroItem.IdLibro = libro.IdLibro;
                        libroItem.Titulo = libro.Titulo;
                        libroItem.Editorial = libro.Editorial;
                        libroItem.FechaPublicacion = libro.FechaPublicacion.Value.ToString("yyyy-MM-dd");
                        libroItem.Genero = libro.Genero;
                        libroItem.NumPaginas = Convert.ToInt32(libro.NumPaginas);
                        libroItem.Precio = Convert.ToDecimal(libro.Precio);
                        libroItem.Stock = Convert.ToInt32(libro.Stock);

                        result.Object = libroItem;
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al traer la informacion";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result AddEF(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CRUDLEntities context = new DL_EF.CRUDLEntities())
                {
                    DL_EF.Libro libroItem = new DL_EF.Libro();

                    context.LibrosAdd(libro.Titulo,
                                      libro.Editorial,
                                      libro.FechaPublicacion,
                                      libro.Genero,
                                      libro.NumPaginas,
                                      libro.Precio,
                                      libro.Stock);

                    context.SaveChanges();

                    result.Object = libroItem.IdLibro;
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result UpdateEF(ML.Libro libro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CRUDLEntities context = new DL_EF.CRUDLEntities())
                {
                    DL_EF.Libro Libroitem = new DL_EF.Libro();

                    context.LibrosUpdate(libro.IdLibro,
                                         libro.Titulo,
                                         libro.Editorial,
                                         libro.FechaPublicacion,
                                         libro.Genero,
                                         libro.NumPaginas,
                                         libro.Precio,
                                         libro.Stock);

                    context.SaveChanges();

                    result.Correct = true;

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result DeleteEF(int IdLibro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CRUDLEntities context = new DL_EF.CRUDLEntities())
                {
                    context.LibroDelete(IdLibro);

                    context.SaveChanges();
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }


            return result;
        }
    }
}
