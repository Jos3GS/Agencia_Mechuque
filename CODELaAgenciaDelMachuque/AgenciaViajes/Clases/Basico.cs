using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Clases
{
    class Basico: Plan
    {
        private float descuento;

        Random rnd = new Random();
        public Basico(float descuento, string ciudad,
            DateTime fechaSalida, DateTime fechaRetorno, bool desayuno, bool almuerzo,
            bool cena, bool bebidas, ulong valor):base(ciudad, fechaSalida, fechaRetorno, desayuno, almuerzo, cena, bebidas, valor)
        {
            this.descuento = descuento;
            NroConsecutivo = "BA" + (rnd.Next(100000, 999999)) + "EF";
        }
    }
}
