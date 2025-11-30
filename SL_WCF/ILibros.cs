using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILibros" in both code and config file together.
    [ServiceContract]
    public interface ILibros
    {
        [OperationContract]
        [ServiceKnownType(typeof(ML.Libro))]
        SL_WCF.Result GetAllEF();

        [OperationContract]
        [ServiceKnownType(typeof(ML.Libro))]
        SL_WCF.Result GetByIdEF(int IdLibro);

        [OperationContract]
        SL_WCF.Result AddEF(ML.Libro libro);

        [OperationContract]
        SL_WCF.Result UpdateEF(ML.Libro libro);

        [OperationContract]
        SL_WCF.Result DeleteEF(int IdLibro);

    }
}
