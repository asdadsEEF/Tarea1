using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using asmxONPE.Models;
using System.Collections.Generic;

namespace asmxONPE.Controllers
{
    public class OnpeController
    {
        Db db = new Db("cnOnpe");


        internal DataSet getDepartamentos()
        {
            db.Sentencia("usp_getDepartamentos");

            return db.getDataSet();
        }


        internal DataSet getProvincias(int idDepartamento)
        {
            db.Sentencia(
                "usp_getProvincias " + idDepartamento
            );

            return db.getDataSet();
        }


        internal DataSet getDistritos(int idProvincia)
        {
            db.Sentencia(
                "usp_getDistritos " + idProvincia
            );

            return db.getDataSet();
        }


        internal DataSet getLocales(int idDistrito)
        {
            db.Sentencia(
                "usp_getLocalesVotacion " + idDistrito
            );

            return db.getDataSet();
        }


        internal DataSet getMesas(int idLocal)
        {
            db.Sentencia(
                "usp_getGruposVotacion " + idLocal
            );

            return db.getDataSet();
        }


        internal DataSet getActa(string mesa)
        {
            db.Sentencia(
                "usp_getGrupoVotacion '" + mesa + "'"
            );

            return db.getDataSet();
        }


        internal DataSet getParticipacion()
        {
            db.Sentencia(
                "usp_getVotos 1,25"
            );

            return db.getDataSet();
        }


        internal DataSet getTotalParticipacion()
        {
            db.Sentencia(
                "SELECT * FROM vTotalVotos"
            );

            return db.getDataSet();
        }

        internal List<Departamento> getDepartamentosModel()
        {
            db.Sentencia("usp_getDepartamentos");

            DataTable dt = db.getDataTable();

            List<Departamento> lista =
                new List<Departamento>();


            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Departamento departamento =
                        new Departamento();

                    departamento.idDepartamento =
                        Convert.ToInt32(
                            fila["idDepartamento"]
                        );

                    departamento.Detalle =
                        fila["Detalle"]
                        .ToString()
                        .Trim();


                    lista.Add(departamento);
                }
            }


            return lista;
        }

        internal List<Provincia> getProvinciasModel(
    int idDepartamento)
        {
            db.Sentencia(
                "usp_getProvincias " + idDepartamento
            );

            DataTable dt = db.getDataTable();

            List<Provincia> lista =
                new List<Provincia>();


            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Provincia provincia =
                        new Provincia();

                    provincia.idProvincia =
                        Convert.ToInt32(
                            fila["idProvincia"]
                        );

                    provincia.Detalle =
                        fila["Detalle"]
                        .ToString()
                        .Trim();

                    lista.Add(provincia);
                }
            }


            return lista;
        }

        internal List<Distrito> getDistritosModel(
    int idProvincia)
        {
            db.Sentencia(
                "usp_getDistritos " + idProvincia
            );

            DataTable dt = db.getDataTable();

            List<Distrito> lista =
                new List<Distrito>();


            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Distrito distrito =
                        new Distrito();

                    distrito.idDistrito =
                        Convert.ToInt32(
                            fila["idDistrito"]
                        );

                    distrito.Detalle =
                        fila["Detalle"]
                        .ToString()
                        .Trim();

                    lista.Add(distrito);
                }
            }


            return lista;
        }

        internal List<LocalVotacion> getLocalesModel(
    int idDistrito)
        {
            db.Sentencia(
                "usp_getLocalesVotacion " + idDistrito
            );

            DataTable dt = db.getDataTable();

            List<LocalVotacion> lista =
                new List<LocalVotacion>();


            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    LocalVotacion local =
                        new LocalVotacion();

                    local.idLocalVotacion =
                        Convert.ToInt32(
                            fila["idLocalVotacion"]
                        );

                    local.RazonSocial =
                        fila["RazonSocial"]
                        .ToString()
                        .Trim();

                    lista.Add(local);
                }
            }


            return lista;
        }

        internal List<Mesa> getMesasModel(
    int idLocal)
        {
            db.Sentencia(
                "usp_getGruposVotacion " + idLocal
            );

            DataTable dt = db.getDataTable();

            List<Mesa> lista =
                new List<Mesa>();


            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Mesa mesa =
                        new Mesa();

                    mesa.idGrupoVotacion =
                        fila["idGrupoVotacion"]
                        .ToString()
                        .Trim();

                    lista.Add(mesa);
                }
            }


            return lista;
        }

        internal Acta getActaModel(string mesa)
        {
            db.Sentencia(
                "usp_getGrupoVotacion '" + mesa + "'"
            );

            DataTable dt = db.getDataTable();


            if (dt == null ||
                dt.Rows.Count == 0)
            {
                return null;
            }


            DataRow fila = dt.Rows[0];


            Acta acta = new Acta();


            acta.Departamento =
                fila["Departamento"]
                .ToString()
                .Trim();

            acta.Provincia =
                fila["Provincia"]
                .ToString()
                .Trim();

            acta.Distrito =
                fila["Distrito"]
                .ToString()
                .Trim();

            acta.RazonSocial =
                fila["RazonSocial"]
                .ToString()
                .Trim();

            acta.Direccion =
                fila["Direccion"]
                .ToString()
                .Trim();

            acta.idGrupoVotacion =
                fila["idGrupoVotacion"]
                .ToString()
                .Trim();

            acta.nCopia =
                fila["nCopia"]
                .ToString()
                .Trim();

            acta.idEstadoActa =
                Convert.ToInt32(
                    fila["idEstadoActa"]
                );

            acta.ElectoresHabiles =
                Convert.ToInt32(
                    fila["ElectoresHabiles"]
                );

            acta.TotalVotantes =
                Convert.ToInt32(
                    fila["TotalVotantes"]
                );

            acta.P1 =
                Convert.ToInt32(
                    fila["P1"]
                );

            acta.P2 =
                Convert.ToInt32(
                    fila["P2"]
                );

            acta.VotosBlancos =
                Convert.ToInt32(
                    fila["VotosBlancos"]
                );

            acta.VotosNulos =
                Convert.ToInt32(
                    fila["VotosNulos"]
                );

            acta.VotosImpugnados =
                Convert.ToInt32(
                    fila["VotosImpugnados"]
                );


            return acta;
        }

        internal List<Participacion> getParticipacionModel()
        {
            db.Sentencia(
                "usp_getVotos 1,25"
            );

            DataTable dt = db.getDataTable();

            List<Participacion> lista =
                new List<Participacion>();


            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Participacion p =
                        new Participacion();


                    p.DPD =
                        fila["DPD"]
                        .ToString()
                        .Trim();

                    p.TV =
                        Convert.ToInt32(
                            fila["TV"]
                        );

                    p.PTV =
                        fila["PTV"]
                        .ToString();

                    p.TA =
                        Convert.ToInt32(
                            fila["TA"]
                        );

                    p.PTA =
                        fila["PTA"]
                        .ToString();

                    p.EH =
                        Convert.ToInt32(
                            fila["EH"]
                        );


                    lista.Add(p);
                }
            }


            return lista;
        }
    }
}