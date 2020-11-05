using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Clases
{
    abstract class Plan
    {

        public enum lista_Actividades { Acuaticas, Terrestres}
        private string ciudad;
        private DateTime fechaSalida;
        private DateTime fechaRetorno;
        private bool desayuno;
        private bool almuerzo;
        private bool cena;
        private bool bebidas;
        private ulong valor;
        private string nroConsecutivo;


        public string Ciudad { get => ciudad; }
        public DateTime FechaSalida { get => fechaSalida; }
        public DateTime FechaRetorno { get => fechaRetorno; }
        public bool Desayuno { get => desayuno; }
        public bool Almuerzo { get => almuerzo; }
        public bool Cena { get => cena; }
        public bool Bebidas { get => bebidas; }
        public ulong Valor { get => valor; }
        internal string NroConsecutivo { get => nroConsecutivo; set => nroConsecutivo = value; }

        protected Plan( string ciudad, DateTime fechaSalida, DateTime fechaRetorno, bool desayuno, bool almuerzo, bool cena, bool bebidas, ulong valor)
        {
          
            this.ciudad = ciudad;
            this.fechaSalida = fechaSalida;
            this.fechaRetorno = fechaRetorno;
            this.desayuno = desayuno;
            this.almuerzo = almuerzo;
            this.cena = cena;
            this.bebidas = bebidas;
            this.valor = valor;
        }
    }
}
