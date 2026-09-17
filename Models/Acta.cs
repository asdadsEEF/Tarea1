using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asmxONPE.Models
{
    public class Acta
    {
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }

        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public string idGrupoVotacion { get; set; }
        public string nCopia { get; set; }

        public int idEstadoActa { get; set; }

        public int ElectoresHabiles { get; set; }
        public int TotalVotantes { get; set; }

        public int P1 { get; set; }
        public int P2 { get; set; }

        public int VotosBlancos { get; set; }
        public int VotosNulos { get; set; }
        public int VotosImpugnados { get; set; }
    }
}