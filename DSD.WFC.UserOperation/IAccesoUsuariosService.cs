using DSD.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DSD.WFC.UserOperation
{
    [ServiceContract]
    public interface IAccesoUsuariosService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "usuarios/login", ResponseFormat = WebMessageFormat.Json)]
        UsuarioBE LoginUsuario(UsuarioBE usuario);
    }
}
