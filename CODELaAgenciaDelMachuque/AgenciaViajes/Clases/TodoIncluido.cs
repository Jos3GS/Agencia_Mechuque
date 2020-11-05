using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Clases
{
    class TodoIncluido: Plan
    {
        private lista_Actividades actividad;
        

        Random rnd = new Random();

        public TodoIncluido(lista_Actividades actividad, string ciudad,
            DateTime fechaSalida, DateTime fechaRetorno, bool desayuno, bool almuerzo,
            bool cena, bool bebidas, ulong valor) : base( ciudad, fechaSalida, fechaRetorno, desayuno, almuerzo, cena, bebidas, valor)
        {
            this.actividad = actividad;
            NroConsecutivo = "TI-" + (rnd.Next(100000, 999999)) +"AB";
        }

        internal lista_Actividades Actividad { get => actividad;}
    }
}
