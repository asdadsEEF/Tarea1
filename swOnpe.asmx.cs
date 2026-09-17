using asmxONPE.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using asmxONPE.Models;
using System.Collections.Generic;

namespace asmxONPE
{
    /// <summary>
    /// Servicio Web ONPE
    /// </summary>

    [WebService(
        Namespace = "http://tempuri.org/"
    )]

    [WebServiceBinding(
        ConformsTo = WsiProfiles.BasicProfile1_1
    )]

    [System.ComponentModel.ToolboxItem(false)]

    public class swOnpe :
        System.Web.Services.WebService
    {
        OnpeController controller =
            new OnpeController();


        [WebMethod]
        public DataSet departamentos()
        {
            return controller.getDepartamentos();
        }


        [WebMethod]
        public DataSet provincias(
            int idDepartamento)
        {
            return controller.getProvincias(
                idDepartamento
            );
        }


        [WebMethod]
        public DataSet distritos(
            int idProvincia)
        {
            return controller.getDistritos(
                idProvincia
            );
        }


        [WebMethod]
        public DataSet locales(
            int idDistrito)
        {
            return controller.getLocales(
                idDistrito
            );
        }


        [WebMethod]
        public DataSet mesas(
            int idLocal)
        {
            return controller.getMesas(
                idLocal
            );
        }


        [WebMethod]
        public DataSet acta(
            string mesa)
        {
            return controller.getActa(
                mesa
            );
        }


        [WebMethod]
        public DataSet participacion()
        {
            return controller.getParticipacion();
        }


        [WebMethod]
        public DataSet totalParticipacion()
        {
            return controller.getTotalParticipacion();
        }

        [WebMethod]
        public List<Departamento> departamentosModel()
        {
            return controller.getDepartamentosModel();
        }

        [WebMethod]
        public List<Provincia> provinciasModel(
    int idDepartamento)
        {
            return controller.getProvinciasModel(
                idDepartamento
            );
        }

        [WebMethod]
        public List<Distrito> distritosModel(
    int idProvincia)
        {
            return controller.getDistritosModel(
                idProvincia
            );
        }

        [WebMethod]
        public List<LocalVotacion> localesModel(
    int idDistrito)
        {
            return controller.getLocalesModel(
                idDistrito
            );
        }

        [WebMethod]
        public List<Mesa> mesasModel(
    int idLocal)
        {
            return controller.getMesasModel(
                idLocal
            );
        }

        [WebMethod]
        public Acta actaModel(
    string mesa)
        {
            return controller.getActaModel(
                mesa
            );
        }

        [WebMethod]
        public List<Participacion> participacionModel()
        {
            return controller.getParticipacionModel();
        }
    }
}