using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Libros" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Libros.svc or Libros.svc.cs at the Solution Explorer and start debugging.
    public class Libros : ILibros
    {
        public SL_WCF.Result GetAllEF()
        {
            ML.Result result = BL.Libro.GetAllEF();
            return new SL_WCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects
            };
        }

        public SL_WCF.Result GetByIdEF(int IdLibro)
        {
            ML.Result result = BL.Libro.GetByIdEF(IdLibro);
            return new SL_WCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects
            };
        }


        public SL_WCF.Result AddEF(ML.Libro libro)
        {
            ML.Result result = BL.Libro.AddEF(libro);
            return new SL_WCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects
            };
        }


        public SL_WCF.Result UpdateEF(ML.Libro libro) 
        {
            ML.Result result = BL.Libro.UpdateEF(libro);
            return new SL_WCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects
            };
        }


        public SL_WCF.Result DeleteEF(int IdLibro)
        {
            ML.Result result = BL.Libro.DeleteEF(IdLibro);
            return new SL_WCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects
            };
        }



    }
}
