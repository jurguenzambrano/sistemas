using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSD.WCF.BankOperation;
using DSD.BusinessEntity;

namespace DSD_Mobipay.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BankOperation oBankOperation = new BankOperation();
            UsuariosBE oUsuariosBE = new UsuariosBE();
            UsuariosBE oUsuariosBE_Resultado = new UsuariosBE();
            Guid gBanco = Guid.Empty;
            string ownerId = "0982BD80-CD6F-43D1-AC91-207202D2A86B";
            gBanco = new Guid(ownerId);
            oUsuariosBE = oBankOperation.getUser(gBanco, "160916000002");
            oUsuariosBE_Resultado.xNombres = "Vargas ,Juan";
            oUsuariosBE_Resultado.xDocumento = "46011127";
            oUsuariosBE_Resultado.xRespuesta = "RESPUESTA_OK";
            Assert.AreNotEqual(oUsuariosBE_Resultado,oUsuariosBE);
        }
    }
}
