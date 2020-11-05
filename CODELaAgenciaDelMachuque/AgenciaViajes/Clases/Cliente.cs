using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Clases
{
    class Cliente
    {
        public enum tipoid { CC, CE, TI, PA};
        private string nombre;
        private DateTime fechaNacimiento;
        private tipoid tipoID;
        private string nroID;

        public string Nombre { get => nombre;}
        public DateTime FechaNacimiento { get => fechaNacimiento; }
        internal tipoid TipoID { get => tipoID;}
        public string NroID { get => nroID;}

        public Cliente(string nombre, DateTime fechaNacimiento, tipoid tipoID, string nroID)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.tipoID = tipoID;
            this.nroID = nroID;
        }
    }
}
